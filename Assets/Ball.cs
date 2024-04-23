using UnityEngine;

public class Ball : MonoBehaviour
{
    public float speed = 5f;
    private Vector2 direction;

    void Start()
    {
        direction = Vector2.one.normalized; 
    }

    void Update()
    {
        transform.Translate(direction * speed * Time.deltaTime);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Paddle"))
        {
            Vector2 hitPoint = collision.GetContact(0).point;
            float paddleCenter = collision.gameObject.transform.position.x;
            direction = new Vector2(hitPoint.x - paddleCenter ,1f).normalized;
        }
        else if (collision.gameObject.CompareTag("Wall"))
        {
            direction.x = -direction.x;
        }
        else if (collision.gameObject.CompareTag("Ceiling"))
        {
            direction.y = -direction.y;
        }
        else if (collision.gameObject.CompareTag("Brick"))
        {
            direction.y = -direction.y;
        }
    }
}