using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{
    public GameObject canvasGameOver;

    void Start()
    {
        Time.timeScale = 1;
    }

    public void gameOver() { 
        canvasGameOver.SetActive(true);
        Time.timeScale = 0;
    }

    public void gameReset() {
        SceneManager.LoadScene(0);
    }
}
