﻿//Project: SLAM
//NAME OF DEVELOPER: P J SIDDHARTHA
//PROFESSOR: MICHEAL J. FINDLER
//Notes: 1. Comments with '////' are regarding the code which are to be worked on. 
//       2. Comments with '//' are used for commenting some parts of code for testing purpose or description of the method.
//       3. Comments with '///' are used for code which is not required.
// Description: This file contains code for the SLAM. Some of the methods used in this code refer to the external libraries
//              the parts whihc needs to be used from the external libraries are referred using the comments with information
//              regarding libraires they are using. Please note that the libraries folder in the script folder is the conversion
//              of the jar (java class files ) to C# (Class files). Some auto generated methods need to be referred as in C# or 
//              need to be written.

                 
using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.IO;

using System.Text.RegularExpressions;

public class SLAM_Main : MonoBehaviour
{

    public Transform parentGO;
    private string OBJPath;
    public Transform target;

    public TextAsset InputTextFile;

    // point cloud center
    private float PTS_CENTER_X = 0;
    private float PTS_CENTER_Y = 0;
    private float PTS_CENTER_Z = 0;

    // point cloud boundary
    private float MIN_PTS_X = 100000.0f;
    private float MAX_PTS_X = -100000.0f;
    private float MIN_PTS_Y = 100000.0f;
    private float MAX_PTS_Y = -100000.0f;
    private float MIN_PTS_Z = 100000.0f;
    private float MAX_PTS_Z = -100000.0f;

    // mesh boundary
    private float MIN_MESH_X = 100000.0f;
    private float MAX_MESH_X = -100000.0f;
    private float MIN_MESH_Y = 100000.0f;
    private float MAX_MESH_Y = -100000.0f;
    private float MIN_MESH_Z = 100000.0f;
    private float MAX_MESH_Z = -100000.0f;

    private float MESH_CENTER_Z = 0.0f;





    // build points in Unity
    private void renderPTS(float[] renderData)
    {

        List<GameObject> GOL = new List<GameObject>();
        List<Mesh> ML = new List<Mesh>();

        int ModelNumPts = renderData.Length / 3;

        int MaxNum = 5400;
        int nChildGO = (ModelNumPts % MaxNum) > 0 ? ((int)(ModelNumPts / MaxNum) + 1) : ((int)(ModelNumPts / MaxNum));

        float sigma = 0.8f;
        float minX = 100000.0f, maxX = -100000.0f, minY = 100000.0f, maxY = -100000.0f, minZ = 100000.0f, maxZ = -100000.0f;

        // find the center of scene
        for (int n = 0; n < ModelNumPts; ++n)
        {
            if (renderData[3 * n] < minX) minX = renderData[3 * n];
            if (renderData[3 * n] > maxX) maxX = renderData[3 * n];
            if (renderData[3 * n + 1] < minY) minY = renderData[3 * n + 1];
            if (renderData[3 * n + 1] > maxY) maxY = renderData[3 * n + 1];
            if (renderData[3 * n + 2] < minZ) minZ = renderData[3 * n + 2];
            if (renderData[3 * n + 2] > maxZ) maxZ = renderData[3 * n + 2];
        }

        PTS_CENTER_X = (minX + maxX) / 2.0f;
        PTS_CENTER_Y = (minY + maxY) / 2.0f;
        PTS_CENTER_Y = (minZ + maxZ) / 2.0f - 90.0f;

        for (int i = 0; i < nChildGO; ++i)
        {
            // create the new child GameObject
            GameObject go = new GameObject();
            go.transform.parent = parentGO;
            go.AddComponent(typeof(MeshFilter));
            go.AddComponent(typeof(MeshRenderer));
            MeshFilter meshFilter = go.GetComponent<MeshFilter>();
            Mesh mesh = meshFilter.mesh;

            mesh.Clear();
            GOL.Add(go);
            ML.Add(mesh);

            // read vertices and triangles into each mesh
            if (i < nChildGO - 1)
            {
                // vertices
                Vector3[] tmpVec = new Vector3[MaxNum * 12];
                for (int n = i * MaxNum, m = 0; n < (i + 1) * MaxNum; ++n, ++m)
                {
                    float x = (renderData[3 * n] - PTS_CENTER_X);
                    float y = (renderData[3 * n + 1] - PTS_CENTER_Y);
                    float z = (renderData[3 * n + 2] - PTS_CENTER_Z);

                    float a_x = x, a_y = y, a_z = z;
                    float b_x = x + sigma, b_y = y, b_z = z;
                    float c_x = x, c_y = y + sigma, c_z = z;
                    float d_x = x + sigma / 3, d_y = y + sigma / 3, d_z = z + sigma;

                    tmpVec[12 * m + 0] = new Vector3(a_x, a_y, a_z); tmpVec[12 * m + 1] = new Vector3(b_x, b_y, b_z); tmpVec[12 * m + 2] = new Vector3(c_x, c_y, c_z);
                    tmpVec[12 * m + 3] = new Vector3(a_x, a_y, a_z); tmpVec[12 * m + 4] = new Vector3(b_x, b_y, b_z); tmpVec[12 * m + 5] = new Vector3(d_x, d_y, d_z);
                    tmpVec[12 * m + 6] = new Vector3(a_x, a_y, a_z); tmpVec[12 * m + 7] = new Vector3(c_x, c_y, c_z); tmpVec[12 * m + 8] = new Vector3(d_x, d_y, d_z);
                    tmpVec[12 * m + 9] = new Vector3(b_x, b_y, b_z); tmpVec[12 * m + 10] = new Vector3(c_x, c_y, c_z); tmpVec[12 * m + 11] = new Vector3(d_x, d_y, d_z);
                }
                // triangles
                int[] tmpTri = new int[MaxNum * 12];
                for (int j = 0; j < MaxNum * 12; ++j)
                {
                    tmpTri[j] = j;
                }
                ML[i].vertices = tmpVec;
                ML[i].triangles = tmpTri;
                GOL[i].GetComponent<Renderer>().material.color = new Color(255, 255, 255, 1.0f);

                tmpVec = null;
                tmpTri = null;
            }
            else
            {
                // vertices
                int remainingPTS = ModelNumPts % MaxNum;
                Vector3[] tmpVec = new Vector3[remainingPTS * 12];
                for (int n = i * MaxNum, m = 0; n < ModelNumPts; ++n, ++m)
                {
                    float x = (renderData[3 * n] - PTS_CENTER_X);
                    float y = (renderData[3 * n + 1] - PTS_CENTER_Y);
                    float z = (renderData[3 * n + 2] - PTS_CENTER_Z);

                    float a_x = x, a_y = y, a_z = z;
                    float b_x = x + sigma, b_y = y, b_z = z;
                    float c_x = x, c_y = y + sigma, c_z = z;
                    float d_x = x + sigma / 3, d_y = y + sigma / 3, d_z = z + sigma;

                    tmpVec[12 * m + 0] = new Vector3(a_x, a_y, a_z); tmpVec[12 * m + 1] = new Vector3(b_x, b_y, b_z); tmpVec[12 * m + 2] = new Vector3(c_x, c_y, c_z);
                    tmpVec[12 * m + 3] = new Vector3(a_x, a_y, a_z); tmpVec[12 * m + 4] = new Vector3(b_x, b_y, b_z); tmpVec[12 * m + 5] = new Vector3(d_x, d_y, d_z);
                    tmpVec[12 * m + 6] = new Vector3(a_x, a_y, a_z); tmpVec[12 * m + 7] = new Vector3(c_x, c_y, c_z); tmpVec[12 * m + 8] = new Vector3(d_x, d_y, d_z);
                    tmpVec[12 * m + 9] = new Vector3(b_x, b_y, b_z); tmpVec[12 * m + 10] = new Vector3(c_x, c_y, c_z); tmpVec[12 * m + 11] = new Vector3(d_x, d_y, d_z);
                }
                // triangles
                int[] tmpTri = new int[remainingPTS * 12];
                for (int j = 0; j < remainingPTS * 12; ++j)
                {
                    tmpTri[j] = j;
                }
                ML[i].vertices = tmpVec;
                ML[i].triangles = tmpTri;
                GOL[i].GetComponent<Renderer>().material.color = new Color(255, 255, 255, 1.0f);

                tmpVec = null;
                tmpTri = null;
            }
        }

        // clear memory
        GOL.Clear();
        GOL = null;
        ML.Clear();
        ML = null;
    }

    // build two point cloud 
    private void render2PTS(float[] pts1, float[] pts2)
    {

        List<GameObject> GOL = new List<GameObject>();
        List<Mesh> ML = new List<Mesh>();

        int ModelNumPts = pts1.Length / 3;

        int MaxNum = 5400;
        int nChildGO = (ModelNumPts % MaxNum) > 0 ? ((int)(ModelNumPts / MaxNum) + 1) : ((int)(ModelNumPts / MaxNum));

        float sigma = 0.6f;
        float minX = 100000.0f, maxX = -100000.0f, minY = 100000.0f, maxY = -100000.0f, minZ = 100000.0f, maxZ = -100000.0f;

        // find the center of scene
        for (int n = 0; n < ModelNumPts; ++n)
        {
            if (pts1[3 * n] < minX) minX = pts1[3 * n];
            if (pts1[3 * n] > maxX) maxX = pts1[3 * n];
            if (pts1[3 * n + 1] < minY) minY = pts1[3 * n + 1];
            if (pts1[3 * n + 1] > maxY) maxY = pts1[3 * n + 1];
            if (pts1[3 * n + 2] < minZ) minZ = pts1[3 * n + 2];
            if (pts1[3 * n + 2] > maxZ) maxZ = pts1[3 * n + 2];
        }

        PTS_CENTER_X = (minX + maxX) / 2.0f;
        PTS_CENTER_Y = (minY + maxY) / 2.0f;
        PTS_CENTER_Y = (minZ + maxZ) / 2.0f - 90.0f;

        for (int i = 0; i < nChildGO; ++i)
        {
            // create the new child GameObject
            GameObject go = new GameObject();
            go.transform.parent = parentGO;
            go.AddComponent(typeof(MeshFilter));
            go.AddComponent(typeof(MeshRenderer));
            MeshFilter meshFilter = go.GetComponent<MeshFilter>();
            Mesh mesh = meshFilter.mesh;

            mesh.Clear();
            GOL.Add(go);
            ML.Add(mesh);

            // read vertices and triangles into each mesh
            if (i < nChildGO - 1)
            {
                // vertices
                Vector3[] tmpVec = new Vector3[MaxNum * 12];
                for (int n = i * MaxNum, m = 0; n < (i + 1) * MaxNum; ++n, ++m)
                {
                    float x = (pts1[3 * n] - PTS_CENTER_X);
                    float y = (pts1[3 * n + 1] - PTS_CENTER_Y);
                    float z = (pts1[3 * n + 2] - PTS_CENTER_Z);

                    float a_x = x, a_y = y, a_z = z;
                    float b_x = x + sigma, b_y = y, b_z = z;
                    float c_x = x, c_y = y + sigma, c_z = z;
                    float d_x = x + sigma / 3, d_y = y + sigma / 3, d_z = z + sigma;

                    tmpVec[12 * m + 0] = new Vector3(a_x, a_y, a_z); tmpVec[12 * m + 1] = new Vector3(b_x, b_y, b_z); tmpVec[12 * m + 2] = new Vector3(c_x, c_y, c_z);
                    tmpVec[12 * m + 3] = new Vector3(a_x, a_y, a_z); tmpVec[12 * m + 4] = new Vector3(b_x, b_y, b_z); tmpVec[12 * m + 5] = new Vector3(d_x, d_y, d_z);
                    tmpVec[12 * m + 6] = new Vector3(a_x, a_y, a_z); tmpVec[12 * m + 7] = new Vector3(c_x, c_y, c_z); tmpVec[12 * m + 8] = new Vector3(d_x, d_y, d_z);
                    tmpVec[12 * m + 9] = new Vector3(b_x, b_y, b_z); tmpVec[12 * m + 10] = new Vector3(c_x, c_y, c_z); tmpVec[12 * m + 11] = new Vector3(d_x, d_y, d_z);
                }
                // triangles
                int[] tmpTri = new int[MaxNum * 12];
                for (int j = 0; j < MaxNum * 12; ++j)
                {
                    tmpTri[j] = j;
                }
                ML[i].vertices = tmpVec;
                ML[i].triangles = tmpTri;
                GOL[i].GetComponent<Renderer>().material.color = new Color(255, 255, 255, 1.0f);

                tmpVec = null;
                tmpTri = null;
            }
            else
            {
                // vertices
                int remainingPTS = ModelNumPts % MaxNum;
                Vector3[] tmpVec = new Vector3[remainingPTS * 12];
                for (int n = i * MaxNum, m = 0; n < ModelNumPts; ++n, ++m)
                {
                    float x = (pts1[3 * n] - PTS_CENTER_X);
                    float y = (pts1[3 * n + 1] - PTS_CENTER_Y);
                    float z = (pts1[3 * n + 2] - PTS_CENTER_Z);

                    float a_x = x, a_y = y, a_z = z;
                    float b_x = x + sigma, b_y = y, b_z = z;
                    float c_x = x, c_y = y + sigma, c_z = z;
                    float d_x = x + sigma / 3, d_y = y + sigma / 3, d_z = z + sigma;

                    tmpVec[12 * m + 0] = new Vector3(a_x, a_y, a_z); tmpVec[12 * m + 1] = new Vector3(b_x, b_y, b_z); tmpVec[12 * m + 2] = new Vector3(c_x, c_y, c_z);
                    tmpVec[12 * m + 3] = new Vector3(a_x, a_y, a_z); tmpVec[12 * m + 4] = new Vector3(b_x, b_y, b_z); tmpVec[12 * m + 5] = new Vector3(d_x, d_y, d_z);
                    tmpVec[12 * m + 6] = new Vector3(a_x, a_y, a_z); tmpVec[12 * m + 7] = new Vector3(c_x, c_y, c_z); tmpVec[12 * m + 8] = new Vector3(d_x, d_y, d_z);
                    tmpVec[12 * m + 9] = new Vector3(b_x, b_y, b_z); tmpVec[12 * m + 10] = new Vector3(c_x, c_y, c_z); tmpVec[12 * m + 11] = new Vector3(d_x, d_y, d_z);
                }
                // triangles
                int[] tmpTri = new int[remainingPTS * 12];
                for (int j = 0; j < remainingPTS * 12; ++j)
                {
                    tmpTri[j] = j;
                }
                ML[i].vertices = tmpVec;
                ML[i].triangles = tmpTri;
                GOL[i].GetComponent<Renderer>().material.color = new Color(255, 255, 255, 1.0f);

                tmpVec = null;
                tmpTri = null;
            }
        }

        // load pts2
        List<GameObject> GOL2 = new List<GameObject>();
        List<Mesh> ML2 = new List<Mesh>();
        int ModelNumPts2 = pts2.Length / 3;

        int MaxNum2 = 5400;
        int nChildGO2 = (ModelNumPts2 % MaxNum2) > 0 ? ((int)(ModelNumPts2 / MaxNum2) + 1) : ((int)(ModelNumPts2 / MaxNum2));

        for (int i = 0; i < nChildGO2; ++i)
        {
            // create the new child GameObject
            GameObject go = new GameObject();
            go.transform.parent = parentGO;
            go.AddComponent(typeof(MeshFilter));
            go.AddComponent(typeof(MeshRenderer));
            MeshFilter meshFilter = go.GetComponent<MeshFilter>();
            Mesh mesh = meshFilter.mesh;

            mesh.Clear();
            GOL2.Add(go);
            ML2.Add(mesh);

            // read vertices and triangles into each mesh
            if (i < nChildGO2 - 1)
            {
                // vertices
                Vector3[] tmpVec = new Vector3[MaxNum2 * 12];
                for (int n = i * MaxNum2, m = 0; n < (i + 1) * MaxNum2; ++n, ++m)
                {
                    float x = (pts2[3 * n] - PTS_CENTER_X);
                    float y = (pts2[3 * n + 1] - PTS_CENTER_Y);
                    float z = (pts2[3 * n + 2] - PTS_CENTER_Z);

                    float a_x = x, a_y = y, a_z = z;
                    float b_x = x + sigma, b_y = y, b_z = z;
                    float c_x = x, c_y = y + sigma, c_z = z;
                    float d_x = x + sigma / 3, d_y = y + sigma / 3, d_z = z + sigma;

                    tmpVec[12 * m + 0] = new Vector3(a_x, a_y, a_z); tmpVec[12 * m + 1] = new Vector3(b_x, b_y, b_z); tmpVec[12 * m + 2] = new Vector3(c_x, c_y, c_z);
                    tmpVec[12 * m + 3] = new Vector3(a_x, a_y, a_z); tmpVec[12 * m + 4] = new Vector3(b_x, b_y, b_z); tmpVec[12 * m + 5] = new Vector3(d_x, d_y, d_z);
                    tmpVec[12 * m + 6] = new Vector3(a_x, a_y, a_z); tmpVec[12 * m + 7] = new Vector3(c_x, c_y, c_z); tmpVec[12 * m + 8] = new Vector3(d_x, d_y, d_z);
                    tmpVec[12 * m + 9] = new Vector3(b_x, b_y, b_z); tmpVec[12 * m + 10] = new Vector3(c_x, c_y, c_z); tmpVec[12 * m + 11] = new Vector3(d_x, d_y, d_z);
                }
                // triangles
                int[] tmpTri = new int[MaxNum2 * 12];
                for (int j = 0; j < MaxNum2 * 12; ++j)
                {
                    tmpTri[j] = j;
                }
                ML2[i].vertices = tmpVec;
                ML2[i].triangles = tmpTri;
                GOL2[i].GetComponent<Renderer>().material.color = new Color(0, 255, 0, 1.0f);

                tmpVec = null;
                tmpTri = null;
            }
            else
            {
                // vertices
                int remainingPTS = ModelNumPts2 % MaxNum2;
                Vector3[] tmpVec = new Vector3[remainingPTS * 12];
                for (int n = i * MaxNum2, m = 0; n < ModelNumPts2; ++n, ++m)
                {
                    float x = (pts2[3 * n] - PTS_CENTER_X);
                    float y = (pts2[3 * n + 1] - PTS_CENTER_Y);
                    float z = (pts2[3 * n + 2] - PTS_CENTER_Z);

                    float a_x = x, a_y = y, a_z = z;
                    float b_x = x + sigma, b_y = y, b_z = z;
                    float c_x = x, c_y = y + sigma, c_z = z;
                    float d_x = x + sigma / 3, d_y = y + sigma / 3, d_z = z + sigma;

                    tmpVec[12 * m + 0] = new Vector3(a_x, a_y, a_z); tmpVec[12 * m + 1] = new Vector3(b_x, b_y, b_z); tmpVec[12 * m + 2] = new Vector3(c_x, c_y, c_z);
                    tmpVec[12 * m + 3] = new Vector3(a_x, a_y, a_z); tmpVec[12 * m + 4] = new Vector3(b_x, b_y, b_z); tmpVec[12 * m + 5] = new Vector3(d_x, d_y, d_z);
                    tmpVec[12 * m + 6] = new Vector3(a_x, a_y, a_z); tmpVec[12 * m + 7] = new Vector3(c_x, c_y, c_z); tmpVec[12 * m + 8] = new Vector3(d_x, d_y, d_z);
                    tmpVec[12 * m + 9] = new Vector3(b_x, b_y, b_z); tmpVec[12 * m + 10] = new Vector3(c_x, c_y, c_z); tmpVec[12 * m + 11] = new Vector3(d_x, d_y, d_z);
                }
                // triangles
                int[] tmpTri = new int[remainingPTS * 12];
                for (int j = 0; j < remainingPTS * 12; ++j)
                {
                    tmpTri[j] = j;
                }
                ML2[i].vertices = tmpVec;
                ML2[i].triangles = tmpTri;
                GOL2[i].GetComponent<Renderer>().material.color = new Color(0, 255, 0, 1.0f);

                tmpVec = null;
                tmpTri = null;
            }
        }

        // clear memory
        GOL.Clear();
        GOL = null;
        ML.Clear();
        ML = null;

        GOL2.Clear();
        GOL2 = null;
        ML2.Clear();
        ML2 = null;
    }

    // display global pts and downsampled pts
    // commented for testing

    //private void twoPCTracking()
    //{

       // float[] renderGLData = jo.Call<float[]>("GlobalPTS");
      //  float[] renderSRCData = jo.Call<float[]>("SourcePTS");

    //    if (renderGLData.Length / 3 >= 200 && renderSRCData.Length / 3 >= 200)
      //      render2PTS(renderGLData, renderSRCData);

        //renderGLData = null;
        //renderSRCData = null;
   // }

    // display point cloud for the scene
    private void buildScenePTS()
    {

        List<float> readData = new List<float>();

        MIN_PTS_X = 100000.0f; MAX_PTS_X = -100000.0f; MIN_PTS_Y = 100000.0f;
        MAX_PTS_Y = -100000.0f; MIN_PTS_Z = 100000.0f; MAX_PTS_Z = -100000.0f;

        // read point data into renderData
        StreamReader sr = new StreamReader(OBJPath);
        string line;
        while ((line = sr.ReadLine()) != null)
        {
            string[] lineTmp = line.Split(' ');
            if (lineTmp[0] == "v")
            {
                float ptsTmpX = float.Parse(lineTmp[1]);
                float ptsTmpY = float.Parse(lineTmp[2]);
                float ptsTmpZ = float.Parse(lineTmp[3]);

                if (ptsTmpX < MIN_PTS_X)
                    MIN_PTS_X = ptsTmpX;
                if (ptsTmpX > MAX_PTS_X)
                    MAX_PTS_X = ptsTmpX;

                if (ptsTmpY < MIN_PTS_Y)
                    MIN_PTS_Y = ptsTmpY;
                if (ptsTmpY > MAX_PTS_Y)
                    MAX_PTS_Y = ptsTmpY;

                if (ptsTmpZ < MIN_PTS_Z)
                    MIN_PTS_Z = ptsTmpZ;
                if (ptsTmpZ > MAX_PTS_Z)
                    MAX_PTS_Z = ptsTmpZ;

                readData.Add(ptsTmpX);
                readData.Add(ptsTmpY);
                readData.Add(ptsTmpZ);
            }
            lineTmp = null;
        }

        sr.Close();

        PTS_CENTER_X = MIN_PTS_X + (MAX_PTS_X - MIN_PTS_X) / 2.0f;
        PTS_CENTER_Y = MIN_PTS_Y + (MAX_PTS_Y - MIN_PTS_Y) / 2.0f;
        PTS_CENTER_Z = MIN_PTS_Z + (MAX_PTS_Z - MIN_PTS_Z) / 2.0f;

        float[] renderData = new float[readData.Count];
        for (int n = 0; n < readData.Count; ++n)
        {
            renderData[n] = readData[n];
        }
        renderPTS(renderData);

        renderData = null;

        readData.Clear();
        readData = null;
    }

    // build mesh for the scene
    private void buildMesh()
    {

        // for mesh settings
        List<Vector3> totalVertices = new List<Vector3>();
        List<Vector3> totalVNormals = new List<Vector3>();

        // save all faces into it
        List<int> totalFacesV = new List<int>();
        List<int> totalFacesVn = new List<int>();

        int numFaces = 0;
        MIN_MESH_X = 100000.0f; MAX_MESH_X = -100000.0f; MIN_MESH_Y = 100000.0f;
        MAX_MESH_Y = -100000.0f; MIN_MESH_Z = 100000.0f; MAX_MESH_Z = -100000.0f;

        StreamReader srpre = new StreamReader(OBJPath);
        string linepre;

        while ((linepre = srpre.ReadLine()) != null)
        {
            string[] lineTmp = linepre.Split(' ');
            if (lineTmp[0] == "v")
            {
                float meshTmpX = float.Parse(lineTmp[1]);
                float meshTmpY = float.Parse(lineTmp[2]);
                float meshTmpZ = float.Parse(lineTmp[3]);
                if (meshTmpX > MAX_MESH_X)
                    MAX_MESH_X = meshTmpX;
                if (meshTmpX < MIN_MESH_X)
                    MIN_MESH_X = meshTmpX;
                if (meshTmpY > MAX_MESH_Y)
                    MAX_MESH_Y = meshTmpY;
                if (meshTmpY < MIN_MESH_Y)
                    MIN_MESH_Y = meshTmpY;
                if (meshTmpZ > MAX_MESH_Z)
                    MAX_MESH_Z = meshTmpZ;
                if (meshTmpZ < MIN_MESH_Z)
                    MIN_MESH_Z = meshTmpZ;

                // add vertex
                totalVertices.Add(new Vector3(meshTmpX, meshTmpY, meshTmpZ));

            }
            else if (lineTmp[0] == "vn")
            {
                // add vertex normals
                totalVNormals.Add(new Vector3(float.Parse(lineTmp[1]), float.Parse(lineTmp[2]), float.Parse(lineTmp[3])));
            }
            else if (lineTmp[0] == "f")
            {
                // add faces (only support fv and fvn)
                for (int nf = 1; nf < lineTmp.Length; ++nf)
                {
                    string[] faceMul = lineTmp[nf].Split('/');
                    totalFacesV.Add(int.Parse(faceMul[0]));
                    totalFacesVn.Add(int.Parse(faceMul[2]));
                }
                ++numFaces;
            }

            lineTmp = null;
        }
        srpre.Close();

        // find the center of the mesh
        Vector3 MESH_CENTER = new Vector3(MIN_MESH_X + (MAX_MESH_X - MIN_MESH_X) / 2.0f, MIN_MESH_Y + (MAX_MESH_Y - MIN_MESH_Y) / 2.0f, MIN_MESH_Z + (MAX_MESH_Z - MIN_MESH_Z) / 2.0f);
        MESH_CENTER_Z = MESH_CENTER[2];

        // move the whole mesh to the center of view
        for (int n = 0; n < numFaces * 3; ++n)
        {
            totalVertices[n] -= MESH_CENTER;
        }

        List<GameObject> GOL = new List<GameObject>();
        List<Mesh> ML = new List<Mesh>();

        int nMesh = 0;

        // since every GameObject can display 65000 faces, 21000(65000/3) is for each child GameObject
        int nChildGO = (numFaces % 21000) > 0 ? ((int)(numFaces / 21000) + 1) : ((int)(numFaces / 21000));
        for (int j = 0; j < nChildGO; ++j)
        {
            // create child GameObject
            GameObject go = new GameObject();
            go.transform.parent = parentGO;
            go.AddComponent(typeof(MeshFilter));
            go.AddComponent(typeof(MeshRenderer));
            MeshFilter meshFilter = go.GetComponent<MeshFilter>();
            Mesh mesh = meshFilter.mesh;

            mesh.Clear();
            GOL.Add(go);
            ML.Add(mesh);

            if (j < nChildGO - 1)
            {
                // read vertices
                Vector3[] tmpVec = new Vector3[21000 * 3];
                Vector3[] tmpVn = new Vector3[21000 * 3];
                for (int n = j * 21000 * 3, m = 0; n < (j + 1) * 21000 * 3; ++n, ++m)
                {
                    tmpVec[m] = totalVertices[totalFacesV[n] - 1];
                    tmpVn[m] = totalVNormals[totalFacesVn[n] - 1];
                }

                ML[nMesh].vertices = tmpVec;
                ML[nMesh].normals = tmpVn;

                // read triangles
                ML[nMesh].triangles = new int[21000 * 3];
                int[] tmpTri = new int[21000 * 3];
                for (int k = 0; k < 21000 * 3; ++k)
                {
                    tmpTri[k] = k;
                }
                ML[nMesh].triangles = tmpTri;
                GOL[nMesh].GetComponent<Renderer>().material = new Material(Shader.Find("VertexLit"));
                ++nMesh;

                tmpTri = null;
                tmpVec = null;
                tmpVn = null;
            }
            else
            {
                int remainingFaces = numFaces % 21000;
                // read remaining vertices
                Vector3[] tmpVec = new Vector3[remainingFaces * 3];
                Vector3[] tmpVn = new Vector3[remainingFaces * 3];
                for (int n = j * 21000 * 3, m = 0; n < numFaces * 3; ++n, ++m)
                {
                    tmpVec[m] = totalVertices[totalFacesV[n] - 1];
                    tmpVn[m] = totalVNormals[totalFacesVn[n] - 1];
                }

                ML[nMesh].vertices = tmpVec;
                ML[nMesh].normals = tmpVn;

                // read triangles
                ML[nMesh].triangles = new int[remainingFaces * 3];
                int[] tmpTri = new int[remainingFaces * 3];
                for (int k = 0; k < remainingFaces * 3; ++k)
                {
                    tmpTri[k] = k;
                }
                ML[nMesh].triangles = tmpTri;
                GOL[nMesh].GetComponent<Renderer>().material = new Material(Shader.Find("VertexLit"));
                ++nMesh;

                tmpTri = null;
                tmpVec = null;
                tmpVn = null;
            }// else		
        } // for(nChild)

        // clear memory
        totalVertices.Clear();
        totalVertices = null;
        totalVNormals.Clear();
        totalVNormals = null;
        totalFacesV.Clear();
        totalFacesV = null;
        totalFacesVn.Clear();
        totalFacesVn = null;

        GOL.Clear();
        GOL = null;
        ML.Clear();
        ML = null;
    }

    // get camera position (x,y,z)
    public Vector3 CamPos()
    {
        Camera Camera_Input = GameObject.FindWithTag("Camera_Input").GetComponent<Camera>();
        Vector3 camPos = Camera_Input.WorldToScreenPoint(target.position);
        return camPos;
    }

  
    // Used for implementing terrain and using it as a minimap for the code.
    //meshc.sharedMesh = terrain1;
    GameObject Main_Terrain;


  // initialize slam
  //// Initialize Slam Needs to be referred from Main Activity.java file from the vgislam folder. 
  
  
    public void Initialise()
    {
        //Mesh  Hbd = Main_Terrain.GetComponent<MeshFilter>();
        //OBJPath = Hbd;
                    }

public void update()

    {
        //// Refers the Object path. The object path in this context is refering to .txt file present in the assests folder.
        OBJPath = InputTextFile.ToString();
    }

}
