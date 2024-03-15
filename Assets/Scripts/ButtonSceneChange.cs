using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonSceneChange : MonoBehaviour
{
    public string sceneToLoad;

    public void loadScene()
    {
        SceneManager.LoadScene(sceneToLoad);
    }

    public void quitGame()
    {
        Application.Quit();
    }
}
