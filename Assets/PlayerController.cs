using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float speed;
    [SerializeField] private Rigidbody rbPlayer;
    [SerializeField] private float jumpPower;
    [SerializeField] private float dashPower;
    [SerializeField] private float positionYGravity;

    private void Update()
    {
        Jump();
        Dash();
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
            rbPlayer.AddForce(Vector3.up * jumpPower);
        }
    }

    private void Dash()
    {
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            rbPlayer.AddForce(Vector3.left * dashPower);
        }
        else if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            rbPlayer.AddForce(Vector3.right * dashPower);
        }
    }
}

//1. player-ot avtomatski da se dvizi napred
//2. koga ke stisneme levo ili desno na tasta. treba playerot da dashnuva levo i desno
//3. jump