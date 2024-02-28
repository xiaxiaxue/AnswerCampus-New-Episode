using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuOptions : MonoBehaviour
{
    public string sceneToLoad;
    public bool loadSceneOnStart = false;

    private void Start()
    {
        if(loadSceneOnStart)
        {
            if(PlayerPrefs.HasKey("Game in Progress"))
            {

            }
            else
            {
                LoadScene(sceneToLoad);
                this.gameObject.SetActive(false);
                PlayerPrefs.SetInt("Game in Progress", 1);
            }
        }
    }

    public void ResetProgress()
    {
        PlayerPrefs.DeleteAll();
    }

    public void SaveCurrentScene()
    {
        PlayerPrefs.SetString("Next Scene", SceneManager.GetActiveScene().name);
    }
    public void LoadNextScene()
    {
        sceneToLoad = PlayerPrefs.GetString("Next Scene", sceneToLoad);
        LoadScene(sceneToLoad);
    }
    public void LoadScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }
}
