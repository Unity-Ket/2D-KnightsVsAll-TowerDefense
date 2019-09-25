using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class defenderHealth : MonoBehaviour
{
    [SerializeField] float health;
    Animator Anim;
    Rigidbody2D defender;

    private void Start()
    {
        Anim = GetComponent<Animator>();
        defender = GetComponent<Rigidbody2D>();
    }

    public void DealDamage(float damage)
    {
        health -= damage;

        if (health <= 0)
        {
            Debug.Log("Archer is dead");
            //TODO death animation
            Anim.SetTrigger("Dead");
            Destroy(gameObject, .7f);
        }
        
    }

}//Golem1Health
