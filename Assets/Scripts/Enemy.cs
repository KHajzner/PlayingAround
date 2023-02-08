using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Enemy : MonoBehaviour
{
	//public PlayerHealth health;
	public int maxHealth = 10;
	public int currentHealth;
	public HealthBar healthBar;
	public SpriteRenderer spriteRenderer;

	    // Start is called before the first frame update
	   void Start()
	    {
		currentHealth = maxHealth;
		healthBar.SetMaxHealth(maxHealth);
	    }

	    // Update is called once per frame
	    void Update()
	    {

	    }
	    
	private void OnTriggerEnter2D(Collider2D collision)
	{
		
		if(collision.tag == "Sword")
		  {
		    TakeDamage(1);
			FlashRed();
		if(currentHealth == 0)
		{
			Destroy(gameObject);
		}
		    
		}
	   }
	   	 public void TakeDamage (int damage)
	    {
	    currentHealth -= damage;
	    healthBar.SetHealth(currentHealth);
	}

	//Doesn't work
	public IEnumerator FlashRed(){
		spriteRenderer.color = Color.red;
		yield return new WaitForSeconds(1);
		spriteRenderer.color = Color.white;
	}
      
}
