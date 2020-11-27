using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{

    public int maxHealth = 4;
    int currentHealth;
    void Start()
    {
        currentHealth = maxHealth;
    }

    public void TakeDamage (int damage=1)
    {
        print("take damage");
        currentHealth -= damage;

        if(currentHealth <=0)
        {
            Die();
        }
    }

    void Die()
    {        
        print("enemy dead");
        Destroy(gameObject);
    }
}

