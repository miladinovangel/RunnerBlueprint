using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
    public static LevelManager Instance;

    private void Awake()
    {
        Instance = this;
    }

    public void NextLevel()
    {
        // treba da proverite koi e posledniot zavrsen level
        // so pomos na PlayerPrefs treba da go zacuvuvate levelot i da pristapuvate


        SceneManager.LoadScene("Game" + PlayerPrefs.GetInt("level"));
    }
}
