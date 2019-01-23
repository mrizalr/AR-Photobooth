using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class loadingBetweenScene : MonoBehaviour {

    public GameObject loadingScreen;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            load_Level("Menu");
        }
    }

	public void load_Level(string scene_name)
    {
        StartCoroutine(LoadAsynchronously(scene_name));
        loadingScreen.SetActive(true);
    }

    IEnumerator LoadAsynchronously(string scene_name)
    {
        AsyncOperation operation = SceneManager.LoadSceneAsync(scene_name);

        while (!operation.isDone)
        {
            Debug.Log(operation.progress);

            yield return null;
        }
    }
}
