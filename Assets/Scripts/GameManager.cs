using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour // Singleton - design pattern - ova funkcionira so skripti koi imaat samo 1 instanca
{
    public static GameManager Instance;

    public GameConfig gameConfig;


    private void Awake()
    {
        Instance = this;
    }
}
