using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float speed;
    [SerializeField] private Rigidbody rbPlayer;
    [SerializeField] private float jumpPower;
    [SerializeField] private float dashPower;
    [SerializeField] private float positionYGravity;

    //private Coroutine coro;

    private bool isDashing;// vodi evidencija dali player-ot momentalno e vo dash

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Debug.Log("Pressed primary button.");
            Debug.Log(Input.mousePosition);
        }

        //if (Input.GetMouseButtonDown(1))
        //    Debug.Log("Pressed secondary button.");

        //if (Input.GetMouseButtonDown(2))
        //    Debug.Log("Pressed middle click.");


        //Jump();
        //Dash();
    }

    private void FixedUpdate() // koga rabotime so fixed update, ne koristime time.deltaTime
    {
        Move();
    }

    private void Move()
    {
        rbPlayer.MovePosition(transform.position + Vector3.forward * speed);
    }

    private void Jump()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if(transform.position.y >= 2 && transform.position.y <= 3)
            {
                rbPlayer.AddForce(Vector3.up * jumpPower);
            }
        }
        //coro = StartCoroutine(TestCoro());
    }

    private void Dash()
    {
        if (Input.GetKeyDown(KeyCode.LeftArrow) && transform.position.x > -2f && !isDashing)// i dokolku ne sme na levata strana
        {
            Dash(Vector3.left);
        }
        else if (Input.GetKeyDown(KeyCode.RightArrow) && transform.position.x < 2f && !isDashing)
        {
            Dash(Vector3.right);
        }
    }

    private void Dash(Vector3 direction)
    {
        rbPlayer.AddForce(direction * dashPower);
        isDashing = true;
        Invoke("ResetDash", 0.75f);
    }

    private void ResetDash()
    {
        isDashing = false;
    }

    //private void Test()
    //{
    //    StopAllCoroutines();
    //    if (coro != null)
    //        StopCoroutine(coro);
    //}

    //private IEnumerator TestCoro()
    //{
    //    yield return new WaitForEndOfFrame();
    //} 
}

//1. player-ot avtomatski da se dvizi napred
//2. koga ke stisneme levo ili desno na tasta. treba playerot da dashnuva levo i desno
//3. jump

//1. jump ne treba da moze da stisneme se dodeka ne spadne playerot
//2. dash ne treba da pravime nadvor od patot