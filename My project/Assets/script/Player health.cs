using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playerhealth : MonoBehaviour
{
   public int maxHealth = 3; 
   public GameObject explosionPrefab;
   [SerializeField] private int currentHealth;
  


   void Start()
   {
       //Initialize player health
       currentHealth = maxHealth;
   }
   public void TakeDamage(int damage)
   {
     currentHealth -= damage;

     if (currentHealth <= 0)
     {
         Die();
         GameOver();
         Explode();
     }
   }

   void Die()
   {
       //Add logic for player death, e.g., play death animation, show game over screen
       Debug.Log("Player Died");
       Destroy(gameObject); // Destroy the player GameObject
       Explode();
   }

       void Explode()
    {
        GameObject explosion = Instantiate(explosionPrefab, transform.position, transform.rotation);
        Destroy(explosion, 1f);
    }

   private void OnTriggerEnter2D(Collider2D collision)
   {
    // Check if the collision object is an enemy bullet
    enemybullet bullet = collision.GetComponent<enemybullet>();
    if (bullet != null && bullet.isEnemy)
    {
        TakeDamage(1);
         
         Destroy(bullet.gameObject);
    }
   }

   private void OnCollisionEnter2D(Collision2D collision)
   {
      if (collision.gameObject.CompareTag("Enemy"))
      {
        Die(); // Player dies instantly on contact with the enemy
        GameOver();
      }
   }
      void GameOver()
   {
      Time.timeScale = 0;
   }
   
}
