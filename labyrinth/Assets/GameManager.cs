using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    private float levelRestartDelay = 1;
    public GameObject pauseMenu;
    // Start is called before the first frame update
   


    // Update is called once per frame
    void Update()
    { if(Input.GetKeyUp(KeyCode.Escape))
        {
            pauseMenu.SetActive(true);
            Time.timeScale = 0;
        }
        if (Input.GetKeyUp(KeyCode.Space))
        {
            pauseMenu.SetActive(false);
            Time.timeScale = 1;
        }
        //Invoke("RestartLevel", levelRestartDelay);
    }
    public void Reolad()
    {
        Invoke("RestartLevel", levelRestartDelay);
        Debug.Log("restart");
    }
    public void RestartLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
