using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterRise : MonoBehaviour
{    
    public bool waterRise = false;
    void Start()
    {
        
    }

    void Update()
    {
        if( waterRise == true)
        {
            transform.position = transform.position + new Vector3(0, 0.00025f, 0);
        }
    }
}
