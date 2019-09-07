using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mageAttack : MonoBehaviour
{
    [SerializeField] GameObject Projectile;
    [SerializeField] GameObject weapon;
    Golem1Spawner myLaneSpawner;

    Animator anim;

    private void Start()
    {
        setLaneSpawner();
        anim = GetComponent<Animator>();
    }

    private void Update()
    {
        if (enemyisthere())
        {
            //Debug.Log("Shooting the Enemy ");
            anim.SetBool("isAttacking", true);
        }
        else
        {
            //Debug.Log("Waiting for Enemy");
            anim.SetBool("isAttacking", false);
        }
    }

    private void setLaneSpawner()
    {
        Golem1Spawner[] attackerSpawners = FindObjectsOfType<Golem1Spawner>();

        foreach (Golem1Spawner spawner in attackerSpawners)
        {
            bool closeEnough = (Mathf.Abs(spawner.transform.position.y - transform.position.y) <= Mathf.Epsilon);

            if (closeEnough)
            {
                myLaneSpawner = spawner;
            }
        }
    }

    private bool enemyisthere()
    {
        if (myLaneSpawner.transform.childCount <= 0)
        {
            return false;
        }
        else
        {
            return true;
        }
    }

    public void Shoot()
    {
        Instantiate(Projectile, weapon.transform.position, transform.rotation);
        //Debug.Log("Projectile being fired: " + Projectile.name);
    }


}//mageAttack