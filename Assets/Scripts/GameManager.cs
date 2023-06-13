using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour // Singleton - design pattern - ova funkcionira so skripti koi imaat samo 1 instanca
{
    public static GameManager Instance;

    public GameConfig gameConfig;
    public ScoreScriptableObject scoreScriptableObject;

    private void Awake()
    {
        Instance = this;
    }

    //public void ResetLevelIndex()
    //{
    //    PlayerPrefs.SetInt("levelIndex", 0); // overwrite
    //    PlayerPrefs.DeleteKey("levelIndex"); // remove
    //}
}
