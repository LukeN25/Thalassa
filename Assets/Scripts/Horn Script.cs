using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HornScript : MonoBehaviour
{
    public BishScript bish;

    public AudioSource audioSource;

    public Animator submarineAnimator;

    private bool canHonkHorn = true;
    
    // Start is called before the first frame update
    public void HonkHorn()
    {
        if (canHonkHorn)
        {

            Debug.Log("Pushed Button");

            submarineAnimator.SetTrigger("Honk");

            bish.ScareOffBish();

            audioSource.Play();

            canHonkHorn = false;

            Invoke("ResetHorn", 30f);
        }
    }

    public void ResetHorn()
    {
        canHonkHorn=true;
    }
}
