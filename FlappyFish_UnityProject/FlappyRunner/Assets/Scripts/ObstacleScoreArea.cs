using UnityEngine;

public class ObstacleScoreArea : MonoBehaviour
{

    GameObject controlCenter;
    void Start()
    {
        controlCenter = GameObject.Find("ControlCenter");
    }

    private void OnTriggerEnter2D(Collider2D collision) {
        controlCenter.GetComponent<ScoreController>().updateScore();
    }

}
