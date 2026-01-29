using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public SceneController sceneController;
    public float velocity = 1;
    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0)) { 
            rb.linearVelocity = Vector2.up * velocity;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        sceneController.gameOver();
        Debug.Log(collision.gameObject.name);
    }
}
