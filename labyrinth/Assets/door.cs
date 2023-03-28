using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class door : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Door1")
        {
            Destroy(collision.gameObject);
        }
    }
    //private void OnTriggerEnter(Collider other)
    //{
    //    if (gameObject.tag == "Door1")
    //    {
    //        Destroy(gameObject);
    //    }
    //}
}
