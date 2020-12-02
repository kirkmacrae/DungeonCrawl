using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{

    public int maxHealth = 5;
    public int currentHealth;

    public HealthBar healthBar;
    
    void Start()
    {
        currentHealth = maxHealth;
        healthBar.SetMaxHealth(maxHealth);
    }    
    public void TakeDamage(int damage=1)
    {
        currentHealth -= damage;
        healthBar.SetHealth(currentHealth);
    }

    public void HealPlayer(int healAmount)
    {
        if (currentHealth + healAmount > maxHealth)
        {
            healthBar.SetHealth(maxHealth);
        }
        else
        {
            currentHealth += healAmount;
            healthBar.SetHealth(currentHealth);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {        
        if (collision.gameObject.layer == LayerMask.NameToLayer("Enemy"))
        {
            TakeDamage();
        }        
    }
}
