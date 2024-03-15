using System.Collections;
using System.Collections.Generic;
using System.Data.SqlTypes;
using TMPro;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class KeyPuzzleButton : MonoBehaviour
{
    string inputedKeys = "";

    public string winKey = "1234";

    public TextMeshProUGUI keyPadText;

    public bool solved = false;

    public AudioSource beep;
    public AudioSource unlock;
    public AudioSource incorrect;

    public Animator animator;

    public XRGrabInteractable doorInteractable;

    public void ButtonPress(string input)
    {
        if (inputedKeys.Length == 4 && inputedKeys != winKey)
        {
            inputedKeys = "";
        }

        if (!solved)
        {
            inputedKeys += input;

            keyPadText.text = inputedKeys;

            beep.Play();
        }
    }

    public void EnterCode()
    {
        if (inputedKeys == winKey)
        {
            Win();
        }
        else
        {
            Lose();
        }
    }

    public void ClearKeyPad()
    {
        inputedKeys = "";
        keyPadText.text = inputedKeys;
    }

    private void Win()
    {
        if (!solved) 
        {
            solved = true;
            animator.SetTrigger("Correct");

            unlock.Play();

            doorInteractable.enabled = true;
        }
    }

    void Lose()
    {
        ClearKeyPad();
        incorrect.Play();
        animator.SetTrigger("Incorrect");
    }
}
