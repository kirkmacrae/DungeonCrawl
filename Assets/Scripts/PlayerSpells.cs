using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSpells : MonoBehaviour
{
    //TODO mana costs for spells, handling different spells
    public ParticleSystem FireCone;

    private PlayerMana playerMana;
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
            Instantiate(FireCone, transform.position, Quaternion.identity);            
        }
        else
        {
            //not enough mana
        }
    }
}
