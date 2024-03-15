using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LEDLight : MonoBehaviour
{
    public KeyPuzzleButton keypad;

    public Material material;

    private void Update()
    {
        if (keypad.solved)
        {
            material.color = Color.green;

            material.SetColor("_EmissionColor", Color.green);
        }
    }

    private void Start()
    {
        material.color = Color.red;

        material.SetColor("_EmissionColor", Color.red);
    }
}
