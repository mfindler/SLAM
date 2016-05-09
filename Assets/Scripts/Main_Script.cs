//Project: SLAM
//NAME OF DEVELOPER: P J SIDDHARTHA
//PROFESSOR: MICHEAL J. FINDLER
//Notes: 1. Comments with '////' are regarding the code which are to be worked on. 
//       2. Comments with '//' are used for commenting some parts of code for testing purpose or description of the method.
//       3. Comments with '///' are used for code which is not required.
// Description: This file used for testing. It is used to test same as code of the SLAM script

using UnityEngine;
using System.Collections;

[RequireComponent(typeof(MeshCollider))]
[RequireComponent(typeof(MeshFilter))]
[RequireComponent(typeof(MeshRenderer))]


public class Main_Script : MonoBehaviour
{

    private bool dirRight = true;
    public float speed = 2.0f;

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
  



    void Update()
    {
        if (dirRight)
            transform.Translate(Vector2.right * speed * Time.deltaTime);
        else
            transform.Translate(-Vector2.right * speed * Time.deltaTime);

        if (transform.position.x >= 10.0f)
        {
            dirRight = false;
        }

        if (transform.position.x <= 1.0f)
        {
            dirRight = true;
        }
    }

    private void clearMeshBuffer()
    {
        foreach (Transform childTransform in gameObject.transform)
        {
            Mesh mesh = childTransform.gameObject.GetComponent<MeshFilter>().mesh;
            Destroy(mesh);
            Destroy(childTransform.gameObject);
        }
    }

}