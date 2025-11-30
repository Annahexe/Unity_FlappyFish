using UnityEngine;
using TMPro;

public class ScoreController : MonoBehaviour
{
    public TMP_Text scoreUI;
    public int score = 0;

    public void updateScore() {
        score++;
        scoreUI.text = score.ToString();
    }
}
