using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCombat : MonoBehaviour
{
    public Animator animator;
    public float attackRate = 2f;
    float nextAttackTime = 0f;

    private void Update()
    {
        if (Time.time >= nextAttackTime)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                Attack();
                nextAttackTime = Time.time + 1f / attackRate;
            }
        }
    }

    void Attack()
    {
        animator.SetTrigger("MeleeAttack");
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (animator.GetCurrentAnimatorStateInfo(0).IsName("Melee Attack"))
        {
            if (collision.gameObject.layer == LayerMask.NameToLayer("Enemy"))
            {                
                collision.GetComponent<Enemy>().TakeDamage();
            }
        }
    }
}
