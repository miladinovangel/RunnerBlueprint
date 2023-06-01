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
        if (Input.GetMouseButtonDown(0)) // koga ke go stisneme leviot klik od gluvceto
        {
            mouseDownPos = Input.mousePosition; // zacuvuvame posicija na strelkata vo momentot koga go klikame leviot klik
        }
        if (Input.GetMouseButtonUp(0)) // koga ke go pustime leviot klik
        {
            Vector3 dif = Input.mousePosition - mouseDownPos;
            if (Mathf.Abs(dif.x) > Mathf.Abs(dif.y))// rastojanie pox sporedeno so y
            {
                if (Input.mousePosition.x < mouseDownPos.x) // logika za mobile input e ista
                {
                    if (transform.position.x > -2f)
                        Dash(Vector3.left);
                }
                else
                {
                    if (transform.position.x < 2f)
                        Dash(Vector3.right);
                }
            }
            else
            {
                if (Input.mousePosition.y > mouseDownPos.y)
                {
                    Jump();
                }
            }
        }
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
        if (transform.position.y >= 2 && transform.position.y <= 3)
        {
            rbPlayer.AddForce(Vector3.up * jumpPower);
        }
    }

    private void Dash(Vector3 direction)
    {
        if (isDashing)
            return; // zavrsi ja funkcijata | ne go izvrsuvaj kodot nadolu

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