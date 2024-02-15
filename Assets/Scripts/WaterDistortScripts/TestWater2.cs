using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class TestWater2 : MonoBehaviour
{
    public float scale2;
    public float waveSpeed2;
    public float waveHeight2;
    void Update()
    {
        CalcNoise2();
    }
    private void CalcNoise2()
    {
        // Get a reference to the Mesh Filter
        MeshFilter mF = GetComponent<MeshFilter>();
        // Create array from Mesh vertices
        Vector3[] verts = mF.mesh.vertices;
        // Iterate through vertices, multiply by scale value and add wavespeed
        //
        for (int i = 0; i < verts.Length; i++)
        {
            float pX = (verts[i].x * scale2) + (Time.time * waveSpeed2) * -2;
            float pZ = (verts[i].z * scale2) + (Time.time * waveSpeed2) * -2;
            // Update the Y component of each vertices using perlin noise
            verts[i].y = Mathf.PerlinNoise(pX + 1, pZ + 1) * waveHeight2;
        }
        // Update the vertices
        mF.mesh.vertices = verts;
        // Recalculate normals as triangles have changed
        //mF.mesh.RecalculateNormals();
        // Recalculate bounds as triangles have changed
        //mF.mesh.RecalculateBounds();
    }
}



