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
        }
        else if (Input.GetKeyUp(KeyCode.UpArrow))
        {
            anim.SetTrigger("Idle");
        }
    }
}
