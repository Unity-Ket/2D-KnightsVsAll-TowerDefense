using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attacker : MonoBehaviour
{
    [Range (0f, 10f)][SerializeField] float walkSpeed =1f;
    GameObject currentTarget;

    private void Awake()
    {
        FindObjectOfType<LevelController>().enemyiesSpawned();
    }

    private void OnDestroy()
    {
        LevelController levelController = FindObjectOfType<LevelController>();
        if (levelController != null)
        {
            FindObjectOfType<LevelController>().enemiesKilled();
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.left * walkSpeed * Time.deltaTime);
        noTarget();
    }

    public void movmentSpeed(float moveSpeed)
    {
        walkSpeed = moveSpeed;
    }

    public void Attack(GameObject defenderTarget)
    {
        GetComponent<Animator>().SetBool("isAttacking", true);
        currentTarget = defenderTarget;
    }

    public void strikeTarget(float damage)
    {
        if (!currentTarget) { return;  }

        defenderHealth health = currentTarget.GetComponent<defenderHealth>();

        if (health)
        {
            health.DealDamage(damage);
        }

    }

    public void noTarget()
    {
        if (!currentTarget)
        {
            GetComponent<Animator>().SetBool("isAttacking", false);
        }
    }

}//Attacker
