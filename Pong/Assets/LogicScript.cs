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

    private void Update()
    {
        if (scoreP1 >= 10)
        {
            // TODO : create UI that says who won, with reset button. Stop player controls, stop ball spawning. Make function in paddle scrips and ball scripts, called via this script
        }
        else if (scoreP2 >= 10)
        {

        }
    }

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
