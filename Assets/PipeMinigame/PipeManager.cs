using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeManager : MonoBehaviour
{
    public GameObject Pipe1;
    public GameObject Pipe2;
    public GameObject Pipe3;
    public GameObject Pipe4;
    public GameObject Pipe5;
    public GameObject Pipe6;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Pipe1.transform.rotation.x == -180 && Pipe2.transform.rotation.x == -180 && Pipe3.transform.rotation.x == -180 && 
            Pipe4.transform.rotation.x == -180 && Pipe5.transform.rotation.x == -180 && Pipe6.transform.rotation.x == -180)
        {
            Debug.Log("Won");
        }
    }
}
