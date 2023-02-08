using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;


public class CoinBehaviour : MonoBehaviour
{
float numberOfCoins = 7f;
	private ScoreManager scoreManager;
	public TMP_Text winning;
	private void Start(){
	    scoreManager = GameObject.Find("Canvas").GetComponent<ScoreManager>();
	}
	
    private void OnTriggerEnter2D(Collider2D collision){
        if(collision.tag == "Player")
        {
        	scoreManager.score += 1f;
            Destroy(gameObject);
            
            if(scoreManager.score == numberOfCoins){
            	//show winning
            	Time.timeScale = 0;
            	winning.text = "You won!";
            }
        }
    }
}
