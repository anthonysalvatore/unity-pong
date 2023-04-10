using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleComputer : MonoBehaviour
{
    private Rigidbody2D rb;
    private Rigidbody2D ball;
    public float speed = 9;
    public float deadZone = 0.2f;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        ball = GameObject.FindGameObjectWithTag("Ball").GetComponent<Rigidbody2D>();       
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (ball.velocity.x > 0)
        {
            if (ball.position.y > transform.position.y + deadZone)
            {
                rb.velocity = Vector2.up * speed;
            }
            else if (ball.position.y < transform.position.y - deadZone)
            {
                rb.velocity = Vector2.down * speed;
            }
            else
            {
                rb.velocity = Vector2.zero;
            }
        }
        else
        {
            if (transform.position.y > deadZone)
            {
                rb.velocity = Vector2.down * speed;
            }
            else if (transform.position.y < -deadZone)
            {
                rb.velocity = Vector2.up * speed;
            }
            else
            {
                rb.velocity = Vector2.zero;
            }
        }
    }
}
