using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyGun : MonoBehaviour
{
    public GameObject bulletprefab; // The bullet prefab to instantiate
    public Transform firePoint;     // the point from where the bullet is fired
    public float ShootingInterval = 2f; //Time between shots

    private float ShootingTimer;

    void Update()
   {
    ShootingTimer += Time.deltaTime;

    if (ShootingTimer >= ShootingInterval)
    {
        Shoot();
        ShootingTimer = 0f;
    }
   }

   void Shoot()
   {
      Instantiate(bulletprefab, firePoint.position, firePoint.rotation);
   }

   
}