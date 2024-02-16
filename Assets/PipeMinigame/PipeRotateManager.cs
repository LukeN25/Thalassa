using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class PipeRotateManager : MonoBehaviour
{

    public bool canRotate = true;
    public Animator animator;
    float newPos = 0;
    
    void Update()
    {
        if(newPos == 4)
        {
            newPos = 0;
        }
    }

    private void OnTriggerEnter(Collider col)
    {
        if(col.tag == "Wrench" && canRotate == true)
        {
            newPos += 1;
            animator.SetFloat("Pos", newPos);
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
