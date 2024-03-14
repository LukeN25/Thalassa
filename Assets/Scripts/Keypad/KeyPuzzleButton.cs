using System.Collections;
using System.Collections.Generic;
using System.Data.SqlTypes;
using TMPro;
using UnityEngine;

public class KeyPuzzleButton : MonoBehaviour
{
    /*public bool LookingAt = false;

    public void Looking()
    {
        LookingAt = true;
    }
    public void NotLooking()
    {
        LookingAt = false;
    }
    */

    string inputedKeys = "";

    public TextMeshProUGUI keyPadText;

    void Update()
    {
        /*if (Input.GetButtonDown("Fire1") && LookingAt == true)
        {
            Debug.Log("Hit");
            KeyPuzzleControl.CodeLength++;
            KeyPuzzleControl.InputCode += gameObject.name;
        }
        */

        keyPadText.text = inputedKeys;
    }

    public void ButtonPress(string input)
    {
        Debug.Log("Button Clicked");
        inputedKeys += input;
    }


}
