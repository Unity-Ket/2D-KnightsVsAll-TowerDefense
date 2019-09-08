using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Golem1 : MonoBehaviour
{
    public void OnTriggerEnter2D(Collider2D otherCollider)
    {
        GameObject otherObject = otherCollider.gameObject;

        if (otherObject.GetComponent<Defender>())
        {
            GetComponent<Attacker>().Attack(otherObject);
        }

    }


}//Golem1