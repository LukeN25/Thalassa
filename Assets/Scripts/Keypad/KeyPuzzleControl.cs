using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class KeyPuzzleControl : MonoBehaviour
{
    public static string KeyCode = "1111";
    public static string InputCode = "";
    public static int CodeLength = 0;
    public Text Display;

    void Update()
    {
        Display.text = InputCode;
        if (CodeLength == 4)
        {
            if (InputCode == KeyCode)
            {
                Debug.Log("Correct");
            }
            else
            {
                CodeLength = 0;
                InputCode = "";
                Debug.Log("Incorrect");
            }
        }
    }
}
