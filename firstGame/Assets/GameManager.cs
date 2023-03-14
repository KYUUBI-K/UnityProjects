using UnityEngine.SceneManagement;
using UnityEngine;

public class GameManager : MonoBehaviour
{


    public playerMove movement;
    public float levelRestartDelay = 1;
    public void EndGame()
    {
        movement.enabled = false;
        Debug.Log("you lost, level was restarted");
        Invoke("RestartLevel", levelRestartDelay);
    }
    public void Win()
    {
        movement.enabled = false;
        Debug.Log("You win");
        Invoke("RestartLevel", levelRestartDelay);
    }
    void RestartLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

}
