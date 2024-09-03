using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyGun1 : MonoBehaviour
{
    public GameObject bulletPrefab; // The bullet prefab to instantiate
    public Transform firePoint;     // the point from where the bullet is fired
    public float shootingInterval = 2f; //Time between shots

    private float shootingTimer;

    void Update()
    {
      //Increment the timer
      shootingTimer += Time.deltaTime;

      //Shoot when the timer reaches the interval
      if(shootingTimer >= shootingInterval)
      {
        Shoot();
        shootingTimer = 0f;
      }
    }
   
   void Shoot()
   {
    //Instantiate the bullet at the fire point's position and rotation
    Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
   }
}
