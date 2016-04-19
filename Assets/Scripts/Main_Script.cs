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