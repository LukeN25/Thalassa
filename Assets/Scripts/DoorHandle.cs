using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DoorHandle : MonoBehaviour
{
    public PipeManager pipemanager;
    public string sceneToLoad;
    public Animator anim;

    void OnTriggerEnter(Collider col)
    {
        if(col.tag == "Wrench" && pipemanager.Win == true)
        {
            anim.SetBool("Interacted", true);
            Debug.Log("working");
            StartCoroutine LoadWin();
        }
    }

    IEnumerator LoadWin()
    {
        yield return new WaitForSeconds(5);
        SceneManager.LoadScene(sceneToLoad);
    }
}
