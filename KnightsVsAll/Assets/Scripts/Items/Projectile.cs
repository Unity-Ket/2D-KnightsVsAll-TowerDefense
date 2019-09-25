using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    [Range(1f, 20f)] [SerializeField] float speed;
    [SerializeField] float damage;

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.right * speed * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        //Debug.Log("I hit: " + other.name);
        var health = other.GetComponent<AttackerHealth>();
        var golem1 = other.GetComponent<Attacker>();

        if (golem1 && health)
        {
            health.DealDamage(damage);
            Destroy(gameObject);
        }
        
    }

}//projectile