using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterRise : MonoBehaviour
{

    //public Transform waterTransform;
    public bool waterRise = false;

    //public GameObject gm;


    // Start is called before the first frame update
    void Start()
    {
        //gm.GetComponent<Transform>;
    }

    // Update is called once per frame
    void Update()
    {
        if( waterRise == true)
        {
            transform.position = transform.position + new Vector3(0, 1, 0);
        }
    }
}
