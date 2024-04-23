using UnityEngine;

public class Brick : MonoBehaviour
{
    public int hitsToBreak = 1;
    public GameObject brickParticle; 

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ball"))
        {
            hitsToBreak--;

            if (hitsToBreak <= 0)
            {
                BreakBrick();
            }
        }
    }

    void BreakBrick()
    {
        Instantiate(brickParticle, transform.position, Quaternion.identity);
        Destroy(gameObject);
    }
}
