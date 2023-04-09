using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Reload : MonoBehaviour
{
    private float levelRestartDelay = 1;
    public GameObject Pause;
    public void Reloading()
    {
        Invoke("RestartLevel", levelRestartDelay);
        Debug.Log("restart");
    }
    public void RestartLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("r"))
        {
            Reloading();
        }
        if (Input.GetKeyUp(KeyCode.Escape))
        {
            Pause.SetActive(true);
            Time.timeScale = 0;
           
        }
        if (Input.GetKeyUp(KeyCode.Space))
        {
            Pause.SetActive(false);
            Time.timeScale = 1;
        }
    }
}
