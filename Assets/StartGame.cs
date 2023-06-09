using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class StartGame : MonoBehaviour
{
    private void Awake()
    {
        int sceneIndex = PlayerPrefs.GetInt("levelIndex");//0
        if (sceneIndex == 0)
        {
            sceneIndex++;
            PlayerPrefs.SetInt("levelIndex", sceneIndex);
        }
        SceneManager.LoadScene(sceneIndex);
    }
}
