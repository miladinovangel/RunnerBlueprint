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

    public void NextLevel() // ovaa funkcija se izvrsuva koga ke klikneme na kopceto next level
    {
        int sceneIndex = PlayerPrefs.GetInt("levelIndex"); //zema zacuvana vrednost (permanentno vo vnatresna memorija) indeks na level
        sceneIndex++; // go zgolemuvame
        PlayerPrefs.SetInt("levelIndex", sceneIndex); // go zacuvuvame permanentno
        SceneManager.LoadScene(sceneIndex);// ja loadirame scenata so noviot level
    }
}
