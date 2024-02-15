using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class PipeRotateManager : MonoBehaviour
{

    //public GameObject pipe1;

    public bool canRotate = false;

    void Start()
    {
        
    }

    
    void Update()
    {
        //if(pipeRotate == true)
        {
            //transform.Rotate(90, 0, 0);
            //pipeRotate = false;
        }
    }

    private void OnTriggerEnter(Collider col)
    {
        if(col.tag == "Wrench" && canRotate == true)
        {
            transform.Rotate(90, 0, 0);
            canRotate = false;
            Debug.Log("wrench");
        }
    }

    private void OnTriggerExit(Collider col)
    {
        if(col.tag == "Wrench")
        {
            canRotate = true;
        }
    }
}
