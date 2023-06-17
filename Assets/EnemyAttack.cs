using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAttack : MonoBehaviour
{
    public Transform firePoint;
    public ParticleSystem muzzleFlashVfx;
    public GameObject bulletPrefab;
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (!collision.name.Contains("Player"))
        {
            return;
        }
        
        muzzleFlashVfx.Play();
        GameObject bulletInstance = Instantiate(bulletPrefab, firePoint.position, Quaternion.identity);
        bulletInstance.GetComponent<Bullet>().Parent = gameObject;
        //Attack
    }
}
