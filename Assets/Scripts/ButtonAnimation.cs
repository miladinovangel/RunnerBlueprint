using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonAnimation : MonoBehaviour
{
    private Animator[] anims;

    private void Start()
    {
        anims = GetComponentsInChildren<Animator>();
        Debug.Log(anims.Length);
    }

    public void OnClick()
    {
        foreach (Animator a in anims)
        {
            a.SetTrigger("ButtenClik");
        }

        //anim.SetTrigger("ButtenClik");
    }
}
