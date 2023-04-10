using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    private GameObject titleManager;
    private GameObject playerTwo;
    public int playerCount;

    // Start is called before the first frame update
    void Awake()
    {
        titleManager = GameObject.FindGameObjectWithTag("TitleManager");
        playerTwo = GameObject.Find("Player 2");

        playerCount = titleManager.GetComponent<TitleManager>().playerCount;
        
        if (playerCount == 1)
        {
           playerTwo.GetComponent<PaddleComputer>().enabled = true;
        }
        else
        {
            playerTwo.GetComponent<PaddleScript>().enabled = true;
        }
    }
}
