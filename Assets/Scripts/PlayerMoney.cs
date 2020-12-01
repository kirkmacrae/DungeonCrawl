using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMoney : MonoBehaviour
{
    public int currentCoins = 0;
    public int startingCoins = 10;
    public int maxCoins = 999;
    public CoinCounter coinCounter;

    void Awake()
    {
        currentCoins = startingCoins;
        coinCounter.SetCoinCount(currentCoins);
    }
    public bool SpendCoins(int coins)
    {
        if (currentCoins - coins >= 0)
        {
            currentCoins -= coins;
        }
        else
        {
            //TODO: 'not enough money' cancel transaction
            return false;
        }

        coinCounter.SetCoinCount(currentCoins);

        return true;
    }

    public void GainCoins(int coins)
    {        
        if(coins + currentCoins > 999)
        {
            currentCoins = 999;
        }
        else
        {
            currentCoins += coins;
        }
        coinCounter.SetCoinCount(currentCoins);
    }  
}
