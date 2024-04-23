using UnityEngine;

public class Paddle : MonoBehaviour
{
    public float speed = 10f;

    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector2.right * horizontalInput * speed * Time.deltaTime);
    }
}
