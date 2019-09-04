using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArcherAttack : MonoBehaviour
{
    [SerializeField] GameObject Projectile;
    [SerializeField] GameObject weapon;

    public void Shoot()
    {
        Instantiate(Projectile, weapon.transform.position, transform.rotation);
    }


}//ArcherAttack