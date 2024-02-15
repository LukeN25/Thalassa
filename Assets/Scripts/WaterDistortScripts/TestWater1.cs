using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class TestWater1 : MonoBehaviour
{
    public float scale1;
    public float waveSpeed1;
    public float waveHeight1;
    void Update()
    {
        CalcNoise1();
    }
    private void CalcNoise1()
    {
        // Get a reference to the Mesh Filter
        MeshFilter mF = GetComponent<MeshFilter>();
        // Create array from Mesh vertices
        Vector3[] verts = mF.mesh.vertices;
        // Iterate through vertices, multiply by scale value and add wavespeed
        //
        for (int i = 0; i < verts.Length; i++)
        {
            float pX = (verts[i].x * scale1) + (Time.time * waveSpeed1) * -2;
            float pZ = (verts[i].z * scale1) + (Time.time * waveSpeed1) * -2;
            // Update the Y component of each vertices using perlin noise
            verts[i].y = Mathf.PerlinNoise(pX + 1, pZ + 1) * waveHeight1;
        }
        // Update the vertices
        mF.mesh.vertices = verts;
        // Recalculate normals as triangles have changed
        //mF.mesh.RecalculateNormals();
        // Recalculate bounds as triangles have changed
        //mF.mesh.RecalculateBounds();
    }
}



