using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoalScript : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Ball"))
        {
            if (gameObject.CompareTag("GoalP2"))
            {
                GameObject.Find("Logic Manager").GetComponent<LogicScript>().player1Score();
                
            }
            
            else if (gameObject.CompareTag("GoalP1"))
            {
                GameObject.Find("Logic Manager").GetComponent<LogicScript>().player2Score();
            }
        }
    }
}
