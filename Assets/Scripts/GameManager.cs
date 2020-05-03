﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GameManager : MonoBehaviour
{
    public GameObject completeLevelUI;
    public float waitingTime = 5.0f;
    bool winGame = false;
    bool gameOver = false;
    public void CompleteLevel()
    {
        completeLevelUI.SetActive(true);
        if(winGame == false)
        {
            Invoke("Restart", waitingTime);
            winGame = true;
        }
        
    }
    public void Restart(){
        SceneManager.LoadScene(0);
    }
    public void GameOver()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex +1);
    }

}