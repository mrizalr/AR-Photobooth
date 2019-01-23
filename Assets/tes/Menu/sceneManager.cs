using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class sceneManager : MonoBehaviour {

    public string sceneName;

    public void sceneLoad()
    {

        SceneManager.LoadScene(sceneName);
    }
    public void backButton()
    {

        Application.Quit();
        Debug.Log("QUIT!");
    }
}
