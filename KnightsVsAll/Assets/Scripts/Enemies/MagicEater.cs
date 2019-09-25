using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MagicEater : MonoBehaviour
{
    [Range(0f, 10f)] [SerializeField] float walkSpeed = 1f;


    private void Update()
    {
        transform.Translate(Vector2.left * walkSpeed * Time.deltaTime);
    }

    public void OnTriggerEnter2D(Collider2D otherCollider)
    {
        GameObject otherObject = otherCollider.gameObject;

        if (otherObject.GetComponent<mageAttack>() && otherObject.GetComponent<Defender>())
        {
            Destroy(otherObject.gameObject);
        }

    }
}
