using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackerHealth : MonoBehaviour
{
    [SerializeField] float health;
    Animator Anim;
    Rigidbody2D Attacker;

    private void Start()
    {
        Anim = GetComponent<Animator>();
        Attacker = GetComponent<Rigidbody2D>();
    }

    public void DealDamage(float damage)
    {
        health -= damage;

        if (health <= 0)
        {
            Anim.SetTrigger("Dead");
            Destroy(gameObject, .7f);
        }
    }

}//Golem1Health
