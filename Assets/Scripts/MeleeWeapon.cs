using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeleeWeapon : MonoBehaviour
{    

    public Sprite sprite;

    public Animator weaponAnimator;

    // Start is called before the first frame update
    void Awake()
    {
        GetComponent<SpriteRenderer>().sprite = sprite;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {        
        if (weaponAnimator.GetCurrentAnimatorStateInfo(0).IsName("Melee Attack"))
        {
            if (collision.gameObject.layer == LayerMask.NameToLayer("Enemy"))
            {
                print("enemy hit");
                collision.GetComponent<Enemy>().TakeDamage();
            }
               

        }
    }
}
