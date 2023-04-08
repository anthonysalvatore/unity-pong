using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallScript : MonoBehaviour
{
    public float speed;
    public Rigidbody2D rb;


    // Start is called before the first frame update
    void Start()
    {
        // Randomly choose a direction for the ball to move in
        float xDirection = Random.Range(0, 2) == 0 ? -1 : 1;
        float yDirection = Random.Range(0, 2) == 0 ? -1 : 1;

        Vector2 launchDirection = new Vector2(xDirection, yDirection).normalized;
        rb.velocity = launchDirection * speed;
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        rb.velocity *= 1.1f;
    }
}
