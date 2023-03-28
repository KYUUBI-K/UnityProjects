using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jump : MonoBehaviour
{



    public float jumpForce = 6f;
    public float forwardForce = 2f;
    private Rigidbody rb;
    private bool isGrounded;


    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            transform.Rotate(45f, 0f, 0f, Space.Self);
        }
            if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            Jump();
            isGrounded = false;
        }
    }
    private void Jump()
    {
        rb.AddForce(transform.up * jumpForce, ForceMode.Impulse);
        rb.AddForce(transform.forward * forwardForce, ForceMode.VelocityChange);
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isGrounded = true;
        }
    }

  
}

