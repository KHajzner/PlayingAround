using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerHealth : MonoBehaviour
{

	public int maxHealth = 10;
	public int currentHealth;
	public TMP_Text winning;
    	public SpriteRenderer spriteRenderer;
	
	public HealthBar healthBar;
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
    if(collision.tag == "Enemy")
		{
			TakeDamage(1);
			FlashRed();
			 if(currentHealth == 0){
            	//show winning
            	Time.timeScale = 0;
            	winning.text = "You lost!";
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
		yield return new WaitForSeconds(1.0f);
		spriteRenderer.color = Color.white;
	}
}
