using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed = 15.0f;
    public GameObject Parent;

    void Update()
    {
        transform.position += transform.right * Time.deltaTime * speed;
        Destroy(gameObject, 1.5f);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (Parent.name.Contains("Player"))
        {
            Enemy enemy = collision.gameObject.GetComponent<Enemy>();
            if (enemy != null)
            {
                enemy.GetDamage();
            }

            gameObject.SetActive(false);
            Destroy(gameObject, 2.0f);
        }
        else
        {
            Player player = collision.gameObject.GetComponent<Player>();
            if (player != null)
            {
                player.GetDamage();
            }
            
            gameObject.SetActive(false);
            Destroy(gameObject, 2.0f);
        }
        
    }
}

