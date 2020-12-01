using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSpells : MonoBehaviour
{
    public PlayerMana playerMana;
    // Start is called before the first frame update
    void Start()
    {
        playerMana = GetComponent<PlayerMana>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            CastSpell();            
        }
    }

    private void CastSpell()
    {

        if(playerMana.SpendMana(1))
        {
            print("cast spell");
        }
        else
        {
            print("not enough mana");
        }
    }
}
