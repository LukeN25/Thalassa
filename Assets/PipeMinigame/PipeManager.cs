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

    public LayerMask pipeRight;

    Vector3 _direction1;
    Vector3 _direction2;
    Vector3 _direction3;
    Vector3 _direction4;
    Vector3 _direction5;
    Vector3 _direction6;

    public bool pipe1Right;
    public bool pipe2Right;
    public bool pipe3Right;
    public bool pipe4Right;
    public bool pipe5Right;
    public bool pipe6Right;

    
    void Update()
    {
        _direction1 = Pipe1.transform.up * -1;
        _direction2 = Pipe2.transform.up * -1;
        _direction3 = Pipe3.transform.up * -1;
        _direction4 = Pipe4.transform.up * -1;
        _direction5 = Pipe5.transform.up;
        _direction6 = Pipe6.transform.up * -1;

        pipe1Right = Physics.Raycast(Pipe1.transform.position, _direction1, 10f , pipeRight);
        pipe2Right = Physics.Raycast(Pipe2.transform.position, _direction2, 10f , pipeRight);
        pipe3Right = Physics.Raycast(Pipe3.transform.position, _direction3, 10f , pipeRight);
        pipe4Right = Physics.Raycast(Pipe4.transform.position, _direction4, 10f , pipeRight);
        pipe5Right = Physics.Raycast(Pipe5.transform.position, _direction5, 10f , pipeRight);
        pipe6Right = Physics.Raycast(Pipe6.transform.position, _direction6, 10f , pipeRight);
        //Debug.DrawRay(Pipe1.transform.position, _direction1, 10f , pipeRight);
        //Debug.DrawRay(Pipe2.transform.position, _direction1, 10f , pipeRight);
        //Debug.DrawRay(Pipe3.transform.position, _direction1, 10f , pipeRight);
        //Debug.DrawRay(Pipe4.transform.position, _direction1, 10f , pipeRight);
        //Debug.DrawRay(Pipe5.transform.position, _direction1, 10f , pipeRight);
        //Debug.DrawRay(Pipe6.transform.position, _direction1, 10f , pipeRight);

        if(pipe1Right == true && pipe2Right == true && pipe3Right == true && pipe4Right == true && pipe5Right == true && pipe6Right == true)
        {
            Debug.Log("Win");
        }

        if (pipe1Right == true || pipe2Right == true || pipe3Right == true || pipe4Right == true || pipe5Right == true || pipe6Right == true)
        {
            Debug.Log("Ray check");
        }
    }
}
