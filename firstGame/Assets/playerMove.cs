
using System;
using UnityEngine;

public class playerMove : MonoBehaviour
{
    public GameManager gm;
    public Rigidbody rb;
   
    public float moveSpeed = 10;
    public float strafeSpeed = 5;
    public float jump = 1;

    protected bool strafeLeft = false;
    protected bool strafeRight = false;
    protected bool doJump = false;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "Obstacle")
        {
            gm.EndGame();
        }
        if (collision.collider.tag == "finish")
        {
            gm.Win();
        }
    }

    void Update()
    {
        if (Input.GetKey("a")) 
        {
            strafeLeft = true;
        }
        else
        {
            strafeLeft = false;
        }
        if (Input.GetKey("d"))
        {
            strafeRight = true;
        }
        else
        {
            strafeRight = false;
        }
        if (Input.GetKey("space"))
        {
            doJump = true;
        }
        else
        {
            doJump = false;
        }

        if (transform.position.y < -5)
        {
            gm.EndGame();
        };

        
    }
     void FixedUpdate()
    {
        rb.MovePosition(transform.position + Vector3.forward*moveSpeed*Time.deltaTime);
        if (strafeLeft)
        {
            rb.AddForce(-strafeSpeed * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if (strafeRight)
        {
            rb.AddForce(strafeSpeed * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if(doJump)
        {
            rb.AddForce(Vector3.up * jump, ForceMode.Impulse);
            doJump = false;
        }
    }
}
