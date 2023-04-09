using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class LogicScript : MonoBehaviour
{
    [Header("Text UI Scores")]
    public TextMeshProUGUI TextP1;
    public TextMeshProUGUI TextP2;

    private int scoreP1 = 0;
    private int scoreP2 = 0;

    public GameObject ball;

    public void player1Score()
    {
        scoreP1 += 1;
        TextP1.text = scoreP1.ToString();
        ResetPosition();
    }
    
    public void player2Score()
    {
        scoreP2 += 1;
        TextP2.text = scoreP2.ToString();
        ResetPosition();
    }

    public void ResetPosition()
    {
        ball.GetComponent<BallScript>().Reset();
    }
}
