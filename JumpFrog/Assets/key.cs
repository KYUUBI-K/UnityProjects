using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class key : MonoBehaviour
{
    public int Key1;
    public int Key2;
    public int Key3;
    private void Start()
    {
        //if (PlayerPrefs.HasKey("Key1"))
        //{
        //    Key1 = PlayerPrefs.GetInt("Key1");
        //}
        //if (PlayerPrefs.HasKey("Key2"))
        //{
        //    Key2 = PlayerPrefs.GetInt("Key2");
        //}
        //if (PlayerPrefs.HasKey("Key3"))
        //{
        //    Key3 = PlayerPrefs.GetInt("Key3");
        //}
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Key1")
        {
            Key1++;
            Destroy(other.gameObject);
            //PlayerPrefs.SetInt("Key1", Key1);

        }


        if (other.gameObject.tag == "Key2")
        {
            Key2++;
            Destroy(other.gameObject);
            //PlayerPrefs.SetInt("Key2", Key2);

        }

        if (other.gameObject.tag == "Key3")
        {
            Key3++;
            Destroy(other.gameObject);
            //PlayerPrefs.SetInt("Key3",Key3);
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Door1" && Key1>0)
        {
            Destroy(collision.gameObject);
        }
        if (collision.gameObject.tag == "Door2" && Key2 > 0)
        {
            Destroy(collision.gameObject);
        }
        if (collision.gameObject.tag == "Door3" && Key3 > 0)
        {
            Destroy(collision.gameObject);
        }
        if (collision.collider.tag == "finish")
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }

}
