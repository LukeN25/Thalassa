using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.VFX;
using UnityEngine.SceneManagement;

public class UnderwaterDepth : MonoBehaviour
{
    [Header("Depth Parameters")]
    [SerializeField] private Transform mainCamera;
    [SerializeField] private int depth = 0;
    public Transform waterTransform;

    [Header("Post Processing Volume")]
    [SerializeField] private Volume postProcessingVolume;

    [Header("Post Processing Profiles")]
    [SerializeField] private VolumeProfile surfacePostProcessing;
    [SerializeField] private VolumeProfile underwaterPostProcessing;

    private bool underWater = false;
    public string SceneToLoad;

    [Header("VisualFX")]
    [SerializeField] VisualEffect Breathing;

   private void Update()
    {
        if(mainCamera.position.y < waterTransform.position.y && !underWater)
        {
            EnableEffects(true);
            
            Debug.Log("Fxplay possible");

            underWater = true;
            StartCoroutine(Drown());
        }
        else if(mainCamera.position.y > waterTransform.position.y && underWater)
        {
            EnableEffects(false);

            underWater = false;
            Debug.Log("Fxplay inpossible");
            StopAllCoroutines();
        }
    }

    private void EnableEffects(bool active)
    {
        if(active)
        {
            postProcessingVolume.profile = underwaterPostProcessing;
            PlayParticle();
        }
        else
        {
            postProcessingVolume.profile = surfacePostProcessing;
            Breathing.Stop();
        }
    }

    void PlayParticle()
    {

        Debug.Log("Playing Particle");
        Breathing.Play();
    }

    IEnumerator Drown()
    {
        yield return new WaitForSeconds(15);
        SceneManager.LoadScene(SceneToLoad);
    }
}
