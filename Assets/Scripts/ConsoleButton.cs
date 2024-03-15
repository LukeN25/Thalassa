using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConsoleButton : MonoBehaviour
{
    [SerializeField] private GameObject nextScreen;
    [SerializeField] private GameObject thisScreen;
    public void ButtonPressed ()
    {
        nextScreen.SetActive(true);
        thisScreen.SetActive(false);
    }
}
