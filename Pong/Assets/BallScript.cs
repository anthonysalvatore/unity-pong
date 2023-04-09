using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallScript : MonoBehaviour
{
    public float speed;
    public Rigidbody2D rb;

    private Vector3 startPosition;


    // Start is called before the first frame update
    void Start()
    {
        startPosition = transform.position;
        // Randomly choose a direction for the ball to move in
        float xDirection = Random.Range(0, 2) == 0 ? -1 : 1;
        float yDirection = Random.Range(0, 2) == 0 ? -1 : 1;

        // Random Offset
        xDirection += Random.Range(-0.2f, 0.2f);
        yDirection += Random.Range(-0.2f, 0.2f);

        Vector2 launchDirection = new Vector2(xDirection, yDirection).normalized;
        rb.velocity = launchDirection * speed;
    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            rb.velocity *= 1.1f;
        }
    }

    public void Reset()
    {
        transform.position = startPosition;
        Start();
    }
}
