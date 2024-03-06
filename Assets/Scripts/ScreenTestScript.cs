using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;
using UnityEngine.UI;

public class ScreenTestScript : MonoBehaviour
{
    public Image image;

    public void ChangeColour(int colourIndex)
    {
        if (colourIndex == 0)
        {
            image.color = Color.red;
        }
        else if(colourIndex == 1)
        {
            image.color = Color.white;
        }
        else if(colourIndex == 2)
        {
            image.color = Color.yellow;
        }
    }
}
