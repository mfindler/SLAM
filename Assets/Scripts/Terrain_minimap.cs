using UnityEngine;
 using System.Collections;
 
 public class Terrain_minimap : MonoBehaviour
{

    Terrain terr; // terrain to modify
    int hmWidth; // heightmap width
    int hmHeight; // heightmap height

    void Start()
    {

        terr = Terrain.activeTerrain;
        hmWidth = terr.terrainData.heightmapWidth;
        hmHeight = terr.terrainData.heightmapHeight;
        Terrain.activeTerrain.heightmapMaximumLOD = 0;
    }

    void Update()
    {

        // get the heights of the terrain under this game object
        float[,] heights = terr.terrainData.GetHeights(0, 0, hmWidth, hmHeight);

        // we set each sample of the terrain in the size to the desired height
        for (int i = 0; i < hmWidth; i++)
            for (int j = 0; j < hmHeight; j++)
            {
                heights[i, j] = 1000;
                //print(heights[i,j]);
            }
        // set the new height
        terr.terrainData.SetHeights(0, 0, heights);

    }
}
