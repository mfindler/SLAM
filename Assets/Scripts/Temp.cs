using UnityEngine;
using System.Collections;

public class Temp : MonoBehaviour
{

    public float velocidadMax;

    public float xMax;
    public float zMax;
    public float xMin;
    public float zMin;
    public Transform target;

    private float x;
    private float z;
    private float tiempo;
    private float angulo;

    private bool bStart = false;
    private bool bReset = false;
    private bool bStop = false;
    private bool bMesh = false;
    private bool bPTS = false;


    public GameObject Objects;
    public GameObject Player;
    private string startButton = "START";
    private string meshButton = "MESH ON";

    private bool bShowMeshButton = false;
    private bool bShowErrorMessage = false;


    // Use this for initialization
    void Start()
    {
        x = Random.Range(-velocidadMax, velocidadMax);
        z = Random.Range(-velocidadMax, velocidadMax);
        angulo = Mathf.Atan2(x, z) * (180 / 3.141592f) + 0;
        transform.localRotation = Quaternion.Euler(0, angulo, 0);

    }


    // Update is called once per frame
    void Update()
    {
        tiempo += Time.deltaTime;

        if (transform.localPosition.x > xMax)
        {
            x = Random.Range(-velocidadMax, 0.0f);
            angulo = Mathf.Atan2(x, z) * (180 / 3.141592f) + 90;
            transform.localRotation = Quaternion.Euler(0, angulo, 0);
            tiempo = 0.0f;
        }
        if (transform.localPosition.x < xMin)
        {
            x = Random.Range(0.0f, velocidadMax);
            angulo = Mathf.Atan2(x, z) * (180 / 3.141592f) + 90;
            transform.localRotation = Quaternion.Euler(0, angulo, 0);
            tiempo = 0.0f;
        }
        if (transform.localPosition.z > zMax)
        {
            z = Random.Range(-velocidadMax, 0.0f);
            angulo = Mathf.Atan2(x, z) * (180 / 3.141592f) + 90;
            transform.localRotation = Quaternion.Euler(0, angulo, 0);
            tiempo = 0.0f;
        }
        if (transform.localPosition.z < zMin)
        {
            z = Random.Range(0.0f, velocidadMax);
            angulo = Mathf.Atan2(x, z) * (180 / 3.141592f) + 90;
            transform.localRotation = Quaternion.Euler(0, angulo, 0);
            tiempo = 0.0f;
        }


        if (tiempo > 1.0f)
        {
            x = Random.Range(-velocidadMax, velocidadMax);
            z = Random.Range(-velocidadMax, velocidadMax);
            angulo = Mathf.Atan2(x, z) * (180 / 3.141592f) + 90;
            transform.localRotation = Quaternion.Euler(0, angulo, 0);
            tiempo = 0.0f;
        }

        transform.localPosition = new Vector3(transform.localPosition.x + x, transform.localPosition.y, transform.localPosition.z + z);
    }



    public Vector3 CamPos()
    {
        Camera Camera_Input = GameObject.FindWithTag("Camera_Input").GetComponent<Camera>();
        Vector3 camPos = Camera_Input.WorldToScreenPoint(target.position);
        return camPos;
    }
    void OnGUI()
    {
        // Create style for a button
        GUIStyle myButtonStyle = new GUIStyle(GUI.skin.button);
        myButtonStyle.fontSize = 35;

        if (GUI.Button(new Rect(Screen.width - 250, Screen.height - 600, 200, 200), startButton, myButtonStyle))
        {
            if (bStart == false)
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

        if (bShowMeshButton)
        {
            if (GUI.Button(new Rect(Screen.width - 250, Screen.height - 380, 200, 200), meshButton, myButtonStyle))
            {
                if (meshButton == "MESH ON")
                {
                    bMesh = true;
                    bPTS = false;
                    meshButton = "MESH OFF";
                }
                else if (meshButton == "MESH OFF")
                {
                    bMesh = false;
                    bPTS = true;
                    meshButton = "MESH ON";
                }
            }
        }

      // popup message if registration is lost
        if (bShowErrorMessage)
        {
            GUIStyle msgStyle = new GUIStyle(GUI.skin.button);
            msgStyle.fontSize = 50;
            msgStyle.normal.textColor = Color.red;
            GUI.Label(new Rect(200, Screen.height - 200, 600, 100), "Lost Registration !", msgStyle);
        }

        GUIStyle errStyle = new GUIStyle(GUI.skin.button);
        errStyle.fontSize = 35;
        //GUI.Label(new Rect(50, 50, 1000, 100), "Camera Position : " + camPos[0].ToString() + " " + camPos[1].ToString() + " " + camPos[2].ToString(), errStyle);
    }





}





