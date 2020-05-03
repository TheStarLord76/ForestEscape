﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Coin : MonoBehaviour
{
    public CoinCounter coinCounter;
    Text label_score;

    AudioSource coinCollect;
    public GameManager gameManager;
    
    void Awake()
    {
        coinCounter = GameObject.Find("CoinCounter").GetComponent<CoinCounter>();
        label_score = GameObject.Find("coinText").GetComponent<Text>();
        label_score.text = " x " + coinCounter.coinCount;
        coinCollect = GameObject.Find("CoinSound").GetComponent<AudioSource>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            // StartCoroutine("PlayAudio");

            coinCounter.coinCount++;
            label_score.text = " x " + coinCounter.coinCount;

            coinCollect.Play();

            gameObject.SetActive(false);
            
            if (coinCounter.coinCount == 7)
            {
                gameManager.CompleteLevel();
            }
        
        }
        
    }
    /*
    IEnumerator PlayAudio()
    {
        coinCollect.Play();
        yield return new WaitForSeconds((float)0.48);
        // gameObject.setActive(false);
        Destroy(this.gameObject);   
    }
    */
}
