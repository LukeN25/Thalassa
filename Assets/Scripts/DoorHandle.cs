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
        if(col.tag == "Hands" && pipemanager.Win == true)
        {
            anim.SetBool("Interacted", true);
        }
    }

    IEnumerator LoadWin()
    {
        yield return new WaitForSeconds(5);
        SceneManager.LoadScene(sceneToLoad);
    }
}
