using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUp : MonoBehaviour
{
    public int healthPowerUpAmount = 0;
    public int coinPowerUpAmount = 0;
    public int manaPowerUpAmount = 0;

    private void OnTriggerEnter2D(Collider2D collision)
    {        
        if (collision.CompareTag("Player"))
        {
            ConsumePowerUp(collision);
        }
    }

    private void ConsumePowerUp(Collider2D player)
    {
        if (healthPowerUpAmount >= 0)
        {
            PlayerHealth ph = player.GetComponent<PlayerHealth>();
            ph.HealPlayer(healthPowerUpAmount);
        }
        if(coinPowerUpAmount >= 0)
        {
            PlayerMoney pm = player.GetComponent<PlayerMoney>();
            pm.GainCoins(coinPowerUpAmount);            
        }
        if (manaPowerUpAmount >= 0)
        {
            PlayerMana playerMana = player.GetComponent<PlayerMana>();
            playerMana.GainMana(manaPowerUpAmount);            
        }
        Destroy(gameObject);
    }
}
