/*
 * Software License Agreement (BSD License)
 *
 *  Starry Night Plugin - http://www.vangoghimaging.com/
 *  Copyright (c) 2010-2013, VanGogh Imaging.
 *
 *  All rights reserved.
 *  
 */

using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.IO;

using System.Text.RegularExpressions;
 
[RequireComponent (typeof (MeshCollider))]
[RequireComponent (typeof (MeshFilter))]
[RequireComponent (typeof (MeshRenderer))]

public class SLAMDemo : MonoBehaviour{
	
	// flags
	private bool bStart = false;
	private bool bReset = false;
	private bool bStop = false;
	private bool bMesh = false;
	private bool bPTS = false;

	private string startButton = "START";
	private string meshButton = "MESH ON";

	private bool bShowMeshButton = false;
	private bool bShowErrorMessage = false;
	
	// camera position
	Vector3 camPos = new Vector3();
	
	private SLAM testDemo = new SLAM();
	
	private void clearMeshBuffer(){
		foreach (Transform childTransform in gameObject.transform) 
		{
			Mesh mesh = childTransform.gameObject.GetComponent<MeshFilter>().mesh;
			Destroy(mesh);
			Destroy(childTransform.gameObject);
		}
	}
	
	// Use this for initialization
	void Start () {
		
		// Initialize SLAM
		testDemo.Initialize();
		bReset = false;
	}
	
	// Update is called once per frame
	void Update () {
		
		if(bStart)
		{			
			// reset model
			if(bReset)
			{
				testDemo.Reset();
				bReset = false;
			}
			
			// start SLAM
			bool bRet = testDemo.StartSLAM();
			// display global point cloud and current scan
			clearMeshBuffer();
			testDemo.parentGO = gameObject.transform;
			testDemo.Display2PC();
			
			// read camera position
			camPos = testDemo.CamPos();
			
			// check SLAM satatus
			if(bRet)
			{
				bShowErrorMessage = false;
			}
			else
			{
				bShowErrorMessage = true;
			}
		}
		
		// stop slam
		if(bStop)
		{
			bStop = false;
			bPTS = true;
			bShowErrorMessage = false;
			bReset = true;
			
			// call StopSlam function
			testDemo.StopSLAM();
		}
		
		// display point cloud
		if(bPTS)
		{
			clearMeshBuffer();
			testDemo.parentGO = gameObject.transform;
			testDemo.ShowPC();
			bPTS = false;
		}
		
		// display mesh
		if(bMesh)
		{
			clearMeshBuffer();
			testDemo.parentGO = gameObject.transform;
			testDemo.ShowMesh();
			bMesh = false;
		}
		
		// rotate scene
		if(Input.touchCount==1 && Input.GetTouch(0).phase==TouchPhase.Moved)
		{
			if(Input.GetTouch(0).deltaPosition.x>0)
			{
				Camera.main.transform.RotateAround(new Vector3(0, 0, 0),
					Vector3.up, 0.2f*Input.GetTouch(0).deltaPosition.x);
				Camera.main.transform.LookAt(new Vector3(0, 0, 0));
			}
			else
			{
				Camera.main.transform.RotateAround(new Vector3(0, 0, 0),
					Vector3.down, -0.2f*(Input.GetTouch(0).deltaPosition.x));
				Camera.main.transform.LookAt(new Vector3(0, 0, 0));
			}
			
			if(Input.GetTouch(0).deltaPosition.y>0)
			{
				Camera.main.transform.RotateAround(new Vector3(0, 0, 0),
					Vector3.left, 0.2f*Input.GetTouch(0).deltaPosition.y);
				Camera.main.transform.LookAt(new Vector3(0, 0, 0));
			}
			else
			{
				Camera.main.transform.RotateAround(new Vector3(0, 0, 0),
					Vector3.right, 0.2f*(-Input.GetTouch(0).deltaPosition.y));
				Camera.main.transform.LookAt(new Vector3(0, 0, 0));
			}
		}
		
		// scale scene
		if(Input.touchCount==2 && Input.GetTouch(0).phase==TouchPhase.Moved && Input.GetTouch(1).phase==TouchPhase.Moved)
		{
			float preDistance = (Input.GetTouch(0).position.x - Input.GetTouch(1).position.x)*(Input.GetTouch(0).position.x - Input.GetTouch(1).position.x) + 
				(Input.GetTouch(0).position.y - Input.GetTouch(1).position.y)*(Input.GetTouch(0).position.y - Input.GetTouch(1).position.y);
			Vector2 deltaT0 = Input.GetTouch(0).deltaPosition+Input.GetTouch(0).position;
			Vector2 deltaT1 = Input.GetTouch(1).deltaPosition+Input.GetTouch(1).position;
			float currDistance = (deltaT0.x-deltaT1.x)*(deltaT0.x-deltaT1.x)+(deltaT0.y-deltaT1.y)*(deltaT0.y-deltaT1.y);
			if(currDistance-preDistance>30 && transform.localScale.x<=3.5f)
			{
				transform.localScale += new Vector3(0.05f, 0.05f, 0.05f);
				Camera.main.transform.LookAt(new Vector3(0, 0, 0));
			}
			else if(currDistance-preDistance<-30 && transform.localScale.x>=0.3f)
			{
				transform.localScale -= new Vector3(0.05f, 0.05f, 0.05f);
				Camera.main.transform.LookAt(new Vector3(0, 0, 0));
			}
		}
	} 
	
	void OnGUI ()
	{			
		// Create style for a button
    	GUIStyle myButtonStyle = new GUIStyle(GUI.skin.button);
    	myButtonStyle.fontSize = 35;
		
		if (GUI.Button(new Rect(Screen.width-250,Screen.height-600,200,200),startButton, myButtonStyle))
		{
			if(bStart==false)
			{
				bStart = true;	
				bStop = false;
				startButton = "STOP";
				bShowMeshButton = false;
				meshButton = "MESH ON";
			}
			else
			{
				bStart = false;
				bStop = true;
				startButton = "START";
				bShowMeshButton = true;
			}
		}		
			
		if(bShowMeshButton)
		{
			if (GUI.Button(new Rect(Screen.width-250,Screen.height-380,200,200),meshButton, myButtonStyle))
			{
				if(meshButton == "MESH ON")
				{
					bMesh = true;	
					bPTS = false;
					meshButton = "MESH OFF";
				}
				else if(meshButton == "MESH OFF")
				{
					bMesh = false;
					bPTS = true;
					meshButton = "MESH ON";
				}
			}		
		}

		
		// popup message if registration is lost
		if(bShowErrorMessage)
		{
			GUIStyle msgStyle = new GUIStyle(GUI.skin.button);
	    	msgStyle.fontSize = 50;
			msgStyle.normal.textColor = Color.red;
			GUI.Label(new Rect(200, Screen.height-200, 600, 100), "Lost Registration !", msgStyle);
		}
		
		GUIStyle errStyle = new GUIStyle(GUI.skin.button);
    	errStyle.fontSize = 35;
		GUI.Label(new Rect(50, 50, 1000, 100), "Camera Position : "+camPos[0].ToString()+" "+ camPos[1].ToString()+" "+ camPos[2].ToString(),errStyle);
	}
	
}




