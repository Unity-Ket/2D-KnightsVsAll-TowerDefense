using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeleeDefender : MonoBehaviour
{
    GameObject currentInvaderTarget;

    void FixedUpdate()
    {
        UpdateAniamtionState();
    }

    private void UpdateAniamtionState()
    {
        if (!currentInvaderTarget)
        {
            GetComponent<Animator>().SetBool("isAttacking", false);
        }
    }

    public void attackInvader(GameObject enemyTarget)
    {
        GetComponent<Animator>().SetBool("isAttacking", true);
        currentInvaderTarget = enemyTarget;
    }

    public void strikeCurrentInvader(float damage)
    {
        if (!currentInvaderTarget) { return; }

        AttackerHealth health = currentInvaderTarget.GetComponent<AttackerHealth>();

        if (health)
        {
            health.DealDamage(damage);
        }

    }

}//meleeDefender
