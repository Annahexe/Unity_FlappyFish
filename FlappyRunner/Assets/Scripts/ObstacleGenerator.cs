using UnityEngine;

public class ObstacleGenerator : MonoBehaviour
{
    public float timeMax = 1.2f;
    private float timeInit = 0;
    public GameObject obstacle;
    public GameObject obstacleOrigin;
    public float high = 3f;

    void Start()
    {
        GameObject obstacleNew = Instantiate(obstacle);
        obstacleNew.transform.position = obstacleOrigin.transform.position;
        Destroy(obstacleNew, 5);
        
    }

    void Update()
    {
        if (timeInit > timeMax) {
            GameObject obstacleNew = Instantiate(obstacle);
            obstacleNew.transform.position = obstacleOrigin.transform.position + new Vector3(0, Random.Range(-high, high), 0);
            Destroy(obstacleNew, 5);
            timeInit = 0;
        } else {
            timeInit += Time.deltaTime;
        }
        
    }
}
