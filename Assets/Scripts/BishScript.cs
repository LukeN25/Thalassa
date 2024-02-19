using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class BishScript : MonoBehaviour
{
    [SerializeField]
    string[] circlingAnimations;

    [SerializeField]
    Animator animator;

    [SerializeField]
    Transform shipTrans;

    private Transform BishTransform;

    private bool isSwimmingAway;

    public float movementSpeed = 10f;

    public void ResetCircling()
    {
        isSwimmingAway = false;

        animator.enabled = true;

        int randomAnim = Random.Range(0, circlingAnimations.Length);

        Debug.Log(randomAnim);

        animator.Play(circlingAnimations[randomAnim]);
    }

    private void Start()
    {
        BishTransform = transform;

        ResetCircling();
    }

    private void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            ScareOffBish();
        }

        if(isSwimmingAway)
        {
            transform.position += transform.forward * Time.deltaTime * movementSpeed;
        }
    }

    public void ScareOffBish()
    {
        animator.enabled = false;

        Vector3 newPosition = BishTransform.position - shipTrans.position;

        Quaternion lookRotation = Quaternion.LookRotation(newPosition);
        BishTransform.rotation = lookRotation;

        isSwimmingAway = true;

        Invoke("ResetCircling", 10f);
    }

    public void DamageShip()
    {
        Debug.Log("Ship damaged");
        ResetCircling();
    }
}
