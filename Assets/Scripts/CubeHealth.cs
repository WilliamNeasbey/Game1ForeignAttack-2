using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeHealth : MonoBehaviour
{
    public float health = 50f;
    public float damage = 10f;
    

    private void OnCollisionEnter(Collision collision)
    {
        Destroy(collision.gameObject);
        if (collision.gameObject.tag == "Enemy")
        {
            Destroy(collision.gameObject);
           TakeDamage(damage);
        }
    }

    public void TakeDamage(float amount)
    {
        health -= amount;
        if (health <= 0f)
        {
            Die();
        }
    }

    public void Die()
    {
        Destroy(gameObject);
       

    }

}
