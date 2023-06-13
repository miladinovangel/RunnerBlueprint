using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeadTest : MonoBehaviour
{
    [SerializeField] private float force;

    private Rigidbody rb;


    private void Start()
    {
        rb = GetComponent<Rigidbody>();

        InvokeRepeating("Test", 1f, 0.5f);
    }

    private void Test()
    {
        rb.AddForce(Vector3.up * force);
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            rb.AddForce(Vector3.up * force);
        }
    }
}
