using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeManager : MonoBehaviour
{
    public Transform Pipe1;
    public Transform Pipe2;
    public Transform Pipe3;
    public Transform Pipe4;
    public Transform Pipe5;
    public Transform Pipe6;



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //if(Pipe1.transform.rotation.x == -180 && Pipe2.transform.rotation.x == -180 && Pipe3.transform.rotation.x == -180 && 
            //Pipe4.transform.rotation.x == -180 && Pipe5.transform.rotation.x == -180 && Pipe6.transform.rotation.x == -180)
        {
            //Debug.Log("Won");
        }

        if (Pipe1.eulerAngles.x == -180)
        {
            Debug.Log("Won");
        }
    }
}
