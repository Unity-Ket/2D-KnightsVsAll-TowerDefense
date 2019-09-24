using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grave : MonoBehaviour
{

    private void OnTriggerStay2D(Collider2D OtherCollision)
    {
        Attacker attacker = OtherCollision.GetComponent<Attacker>();

        if (attacker)
        {
            //TODO animate
        }

    }

}//Grave
