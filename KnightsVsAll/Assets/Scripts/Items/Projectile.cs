using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    [Range(0f, 5f)] [SerializeField] float speed;
    [Range(10f, 50f)] [SerializeField] float damage;

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.right * speed * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        //Debug.Log("I hit: " + other.name);
        var health = other.GetComponent<Golem1Health>();
        var golem1 = other.GetComponent<Golem1>();

        if (golem1 && health)
        {
            health.DealDamage(damage);
            Destroy(gameObject);
        }
        
    }

}//projectile