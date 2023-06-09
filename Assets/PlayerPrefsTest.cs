using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPrefsTest : MonoBehaviour
{
    //private int score;

    public int newScore;

    private void Start()
    {
        // player-ot pravi nov score i sakame da go zacuvame
        //PlayerPrefs.SetInt("score", 15);// zacuvvuanje
        PlayerPrefs.SetFloat("testFloat", 2f);
        PlayerPrefs.SetString("username", "Angel");
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.S))
        {
            // pristapuvanje do score
            int score = PlayerPrefs.GetInt("score");
            Debug.Log(score);
        }

        if (Input.GetKeyDown(KeyCode.N))
        {
            if (PlayerPrefs.GetInt("score") < newScore)
            {
                PlayerPrefs.SetInt("score", newScore);
            }
        }
    }
}
