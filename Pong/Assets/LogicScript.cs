using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class LogicScript : MonoBehaviour
{
    [Header("Text UI Scores")]
    public TextMeshProUGUI TextP1;
    public TextMeshProUGUI TextP2;

    public int scoreToWin = 10;

    private int scoreP1 = 0;
    private int scoreP2 = 0;

    public GameObject ball;
    public GameObject gameOverScreen;
    public TextMeshProUGUI playerWin;

    public void player1Score()
    {
        scoreP1 += 1;
        TextP1.text = scoreP1.ToString();
        if (scoreP2 >= scoreToWin)
        {
            GameOver("p1");
            return;
        }
        ResetPosition();
    }
    
    public void player2Score()
    {
        scoreP2 += 1;
        TextP2.text = scoreP2.ToString();
        if (scoreP2 >= scoreToWin) 
        {
            GameOver("p2");
            return;
        }
        ResetPosition();
    }

    public void ResetPosition()
    {
        ball.GetComponent<BallScript>().Reset();
    }

    private void GameOver(string winner)
    {
        gameOverScreen.SetActive(true);
        if (winner == "p1")
        {
            playerWin.text = "Player 1 Wins!";
        }
        else
        {
            playerWin.text = "Player 2 Wins!";
        }
    }

    public void ResetGame()
    {
        SceneManager.LoadScene("Pong");
    }
}
