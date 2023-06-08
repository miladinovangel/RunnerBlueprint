using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterAnimationController : MonoBehaviour
{
    private Animator anim;


    private void Start()
    {
        anim = GetComponentInChildren<Animator>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            anim.SetTrigger("Walk");
            anim.SetBool("Walking", true);
        }
        else if (Input.GetKeyUp(KeyCode.UpArrow))
        {
            anim.SetTrigger("Idle");
            anim.SetBool("Walking", false);
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            anim.SetTrigger("Jump");
        }


        // int trigger
        //anim.SetInteger("test", 5);
        //anim.SetFloat("test", 5f);
    }
}


// Sto treba da imate vo proektot:
// - Scripts (kod/logika/programiranje)
// - Prefabs (treba da bide organiziran proektot so prefabi)
// - Scena (rabota so sceni)
// - Animacii
// - Grafika (mora da imate UI)
// - 3d modeli 
// - zvuci i muzika SFX
// - efekti?
// - fizika
// - 








// Scriptable object
// PlayerPrefs
// Particles