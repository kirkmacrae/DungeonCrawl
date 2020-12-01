using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LootDrop : MonoBehaviour
{

    public GameObject prefabMeat;
    public GameObject prefabCoin;

    /* Loot Table (1-100 + modifier):
    1-50 nothing
    51-75 meat
    76-100 coin
    100+ bigger coin?
    */

    public void DropLoot(Transform dropLocation, int TreasureLevel=0)
    {
        
        int lootNumber = ((int)Random.Range(1f, 100f))+TreasureLevel;        

        if(lootNumber <=50)
        {
            print("no loot");
            //nothing
        }else if(lootNumber <= 75)
        {
            print("meat");
            Instantiate(prefabMeat, dropLocation.position, Quaternion.identity);
        }
        else if(lootNumber <= 100)
        {
            print("coin");
            Instantiate(prefabCoin, dropLocation.position, Quaternion.identity);
        }
        else
        {
            print("big loot");
            //drop bigger coin?
        }
    }
}
