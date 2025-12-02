using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ScoreController : MonoBehaviour
{
    public TMP_Text scoreUI;
    public int score = 0;

    public Image coinImage;           
    public Sprite bronzeCoinSprite;
    public Sprite silverCoinSprite;
    public Sprite goldenCoinSprite;   

    public void updateScore() {
        score++;
        scoreUI.text = score.ToString();
        if (score >= 8)
        {
            coinImage.sprite = goldenCoinSprite;
        }
        else if (score >= 4)
        {
            coinImage.sprite = silverCoinSprite;
        }
        else {
            coinImage.sprite = bronzeCoinSprite;
        }
    }
}
