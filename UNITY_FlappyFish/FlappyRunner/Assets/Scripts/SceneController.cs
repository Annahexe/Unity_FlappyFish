using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{
    public GameObject canvasGameOver;
    public GameObject canvasGameStart;

    void Start()
    {
        Time.timeScale = 0;
    }

    public void gameOver() { 
        canvasGameOver.SetActive(true);
        Time.timeScale = 0;
    }

    public void gameReset() {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void gameStart()
    {
        canvasGameStart.SetActive(false);
        Time.timeScale = 1;
    }

    public void gameQuit()
    {
        Application.Quit();
    }
}
