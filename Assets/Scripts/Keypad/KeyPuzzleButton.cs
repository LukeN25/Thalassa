using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyPuzzleButton : MonoBehaviour
{
    public bool LookingAt = false;

    public void Looking()
    {
        LookingAt = true;
    }
    public void NotLooking()
    {
        LookingAt = false;
    }
    
    void Update()
    {
        if (Input.GetButtonDown("Fire1") && LookingAt == true)
        {
            Debug.Log("Hit");
            KeyPuzzleControl.CodeLength++;
            KeyPuzzleControl.InputCode += gameObject.name;
        }
    }
}
