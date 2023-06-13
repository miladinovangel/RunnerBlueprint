using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
    public static LevelManager Instance;

    private int lastSceneIndex = 0;
    private static int selectedScene = 0;

    private void Awake()
    {
        Instance = this;
    }

    public void NextLevel() // ovaa funkcija se izvrsuva koga ke klikneme na kopceto next level
    {
        //int sceneIndex = PlayerPrefs.GetInt("levelIndex"); //zema zacuvana vrednost (permanentno vo vnatresna memorija) indeks na level
        //sceneIndex++; // go zgolemuvame
        //PlayerPrefs.SetInt("levelIndex", sceneIndex); // go zacuvuvame permanentno

        List<int> scenesIndices = new List<int>(new int[] { 1, 2, 3 }); // kreirame lista so indeksi na 3te sceni

        int randomIndex = 0;
        if (selectedScene != 0)
        {
            scenesIndices.Remove(selectedScene);
            randomIndex = Random.Range(0, scenesIndices.Count); // izbirame random index
        }

        selectedScene = scenesIndices[randomIndex]; // ja zemame vrednosta za toj index

        SceneManager.LoadScene(selectedScene); // loadirame scene





        //scenesIndices.Remove(lastSceneIndex);

        //if (sceneIndex <= 3)
        //{
        //    scenesIndices = new List<int>(new int[] { 1, 2, 3 });
        //}
        //else
        //{
        //    //druga logika
        //}
        // dodadete logika sto ke proveruva dali sme stignale do 4tiot level ili pogolem
        // dokolku sme stignate - odi na random level od 1 do 3
    }
}
