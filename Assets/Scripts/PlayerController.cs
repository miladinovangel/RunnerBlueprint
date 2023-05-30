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

    private bool isDashing;// vodi evidencija dali player-ot momentalno e vo dash
    private Vector3 mouseDownPos;

    private void Update()
    {
        //Debug.Log(Input.mousePosition);

        if (Input.GetMouseButtonDown(0)) // koga ke go stisneme leviot klik od gluvceto
        {
            Debug.Log("Pressed primary button."); // pecatenje
            Debug.Log(Input.mousePosition); // pecatenje
            mouseDownPos = Input.mousePosition; // zacuvuvame posicija na strelkata vo momentot koga go klikame leviot klik
        }
        if (Input.GetMouseButtonUp(0)) // koga ke go pustime leviot klik
        {
            Debug.Log("Released primary button."); // pecatenje
            Debug.Log(Input.mousePosition); // pecatenje
            Vector3 dif = Input.mousePosition - mouseDownPos;
            Debug.Log(dif);

            if (Mathf.Abs(dif.x) > Mathf.Abs(dif.y))// rastojanie pox sporedeno so y
            {
                if (Input.mousePosition.x < mouseDownPos.x)
                {
                    Debug.Log("Swipe left");
                    Dash(Vector3.left);
                }
                else
                {
                    Debug.Log("Swipe right");
                    Dash(Vector3.right);
                }
            }
            else
            {
                if (Input.mousePosition.y > mouseDownPos.y)
                {
                    // swipe up
                    Jump();
                }
            }
            

            
        }

        // 2 nacin kako moze da se detektira input na mobilni uredi (i popravilen i optimalen)
        // mobile device input
        //Touch touch = Input.GetTouch(0);
        //if (touch.phase == TouchPhase.Began) // Input.GetMouseButtonDown(0)
        //{
        //    Vector3 touchPosition = touch.position; // Input.mousePosition
        //}
        //if (touch.phase == TouchPhase.Ended) // Input.GetMouseButtonUp(0)
        //{

        //}


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
//if (Input.GetKeyDown(KeyCode.Space))
        {
            if(transform.position.y >= 2 && transform.position.y <= 3)
            {
                rbPlayer.AddForce(Vector3.up * jumpPower);
            }
        }
    }

    //private void Dash()
    //{
    //    if (Input.GetKeyDown(KeyCode.LeftArrow) && transform.position.x > -2f && !isDashing)// i dokolku ne sme na levata strana
    //    {
    //        Dash(Vector3.left);
    //    }
    //    else if (Input.GetKeyDown(KeyCode.RightArrow) && transform.position.x < 2f && !isDashing)
    //    {
    //        Dash(Vector3.right);
    //    }
    //}

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
}

//1. player-ot avtomatski da se dvizi napred
//2. koga ke stisneme levo ili desno na tasta. treba playerot da dashnuva levo i desno
//3. jump

//1. jump ne treba da moze da stisneme se dodeka ne spadne playerot
//2. dash ne treba da pravime nadvor od patot