using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private Rigidbody rbPlayer;
    [SerializeField] private float positionYGravity;
    [SerializeField] private float finishZPosition;

    private bool isLevelCompleted;
    

    private bool isDashing;// vodi evidencija dali player-ot momentalno e vo dash
    private Vector3 mouseDownPos;


    private void Start()
    {
        Debug.LogError(GameManager.Instance.gameConfig.playerSpeed);
    }

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

        if (transform.position.z > finishZPosition)
        {
            // treba da ja prikazeme animacijata Car_show
        }

        //if (Input.GetKeyDown(KeyCode.S))//show
        //{
            
        //}
        //else if (Input.GetKeyDown(KeyCode.H)) // hide
        //{
            
        //}

        if (transform.position.z > GameManager.Instance.gameConfig.playerWinZTarget)
        {
            // game won
            UIManager.Instance.ShowWinPanel();
            //isLevelCompleted = true;
            //Time.timeScale = 0; // ne e dobra praksa ova da go pravite
        }
    }

    private void FixedUpdate() // koga rabotime so fixed update, ne koristime time.deltaTime
    {
        Move();
    }

    private void Move()
    {
        if (isLevelCompleted)
            return;

        rbPlayer.MovePosition(transform.position + Vector3.forward * GameManager.Instance.gameConfig.playerSpeed);
    }

    private void Jump()
    {
        if (isLevelCompleted)
            return;

        if (transform.position.y >= 2 && transform.position.y <= 3)
        {
            rbPlayer.AddForce(Vector3.up * GameManager.Instance.gameConfig.playerJumpPower);
        }
    }

    private void Dash(Vector3 direction)
    {
        if (isLevelCompleted || isDashing)
            return; // zavrsi ja funkcijata | ne go izvrsuvaj kodot nadolu

        rbPlayer.AddForce(direction * GameManager.Instance.gameConfig.playerDashPower);
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