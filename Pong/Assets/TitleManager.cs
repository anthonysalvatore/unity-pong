using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TitleManager : MonoBehaviour
{
    public int playerCount;

    private void Awake()
    {
        DontDestroyOnLoad(gameObject);    
    }

    public void OnePlayer()
    {
        playerCount = 1;
        SceneManager.LoadScene(1);
    }

    public void TwoPlayer()
    {
        playerCount = 2;
        SceneManager.LoadScene(1);
    }
}
