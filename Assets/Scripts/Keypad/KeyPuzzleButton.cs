using System.Collections;
using System.Collections.Generic;
using System.Data.SqlTypes;
using TMPro;
using UnityEngine;

public class KeyPuzzleButton : MonoBehaviour
{
    string inputedKeys = "";

    public string winKey = "1234";

    public TextMeshProUGUI keyPadText;

    private bool solved = false;

    public AudioSource beep;
    public AudioSource unlock;
    public AudioSource incorrect;

    public Animator animator;

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
        }
    }

    void Lose()
    {
        ClearKeyPad();
        incorrect.Play();
        animator.SetTrigger("Incorrect");
    }
}
