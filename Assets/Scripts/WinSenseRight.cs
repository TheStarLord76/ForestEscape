﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinSenseRight : MonoBehaviour
{
    CoinCounter coinCounter; bool escape = false;
    GameObject leftArrow, rightArrow;
    Collider2D currentCollider; GameManager gameManager;
    void Start(){
        coinCounter = GameObject.Find("CoinCounter").GetComponent<CoinCounter>();
        currentCollider = GetComponent<Collider2D>();
        if(rightArrow = GameObject.Find("rightarrow")) rightArrow.SetActive(false);
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
    }
    void Update(){
        if(coinCounter.coinCount == 10) {
            currentCollider.enabled = false; escape = true;
            rightArrow.SetActive(true);
        }
    }
    void OnTriggerEnter2D(Collider2D collider){
        if(collider.tag == "Player" && escape == true ){
            gameManager.CompleteLevel();
        }
    }
}
