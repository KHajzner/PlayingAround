using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwordBehaviour : MonoBehaviour
{
public SpriteRenderer spriteRenderer;
public Sprite newSprite;


 	private void OnTriggerEnter2D(Collider2D collision){
        if(collision.tag == "Player")
        {
        	spriteRenderer.sprite = newSprite;
            Destroy(gameObject);
            
        }
    }
}
