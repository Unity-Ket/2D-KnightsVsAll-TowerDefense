using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamgePlayer : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D otherCollider)
    {
        GameObject otherObject = otherCollider.gameObject;

        if (otherObject.GetComponent<Golem1>())
        {
            int damage = 10;
            FindObjectOfType<PlayerLivesDisplay>().takeLives(damage);
        }
        else if (otherObject.GetComponent<Fox>())
        {
            int damage = 5;
            FindObjectOfType<PlayerLivesDisplay>().takeLives(damage);
        }
    }
}//dmgPlayer
