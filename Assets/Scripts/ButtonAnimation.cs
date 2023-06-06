using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonAnimation : MonoBehaviour
{
    //private Animator[] anims;
    private Animator anim;

    private void Start()
    {
        //anims = GetComponentsInChildren<Animator>();
        //Debug.Log(anims.Length);
        anim = GetComponentInChildren<Animator>();
    }

    public void OnClick()
    {
        //foreach (Animator a in anims)
        //{
        //    a.SetTrigger("ButtenClik");
        //}

        anim.SetTrigger("ButtenClik");
        anim.speed = 1.5f;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            anim.speed = 1.5f;
        }
        else if (Input.GetKeyDown(KeyCode.S))
        {
            anim.speed = 1f;
        }
    }
}


// napravete defaultna animacija na karakterot da bide idle
// koga ke klikneme na kopceto ArrowUp, treba da se napravi tranzicija kon walk animacija
// koga ke se pusti kopceto ArrowUp, treba da se vratite na idle animacija