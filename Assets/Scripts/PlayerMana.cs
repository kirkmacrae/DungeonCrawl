using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMana : MonoBehaviour
{
    public int currentMana = 0;
    public int startingMana = 5;
    public int maxMana = 5;
    public ManaBar manaBar;

    void Start()
    {
        
        currentMana = startingMana;
        manaBar.SetMana(currentMana);
        manaBar.SetMaxMana(maxMana);
    }
    public bool SpendMana(int mana)
    {
        if (currentMana - mana >= 0)
        {
            currentMana -= mana;
            manaBar.SetMana(currentMana);

            return true;
        }
        else
        {            
            return false;
        }

       
    }

    public void GainMana(int mana)
    {
        if (mana + currentMana > maxMana)
        {
            currentMana = maxMana;
        }
        else
        {
            currentMana += mana;
        }
        manaBar.SetMana(currentMana);
    }
}
