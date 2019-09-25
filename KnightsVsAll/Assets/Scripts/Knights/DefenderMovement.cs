using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DefenderMovement : MonoBehaviour
{

    [Range(0f, 10f)] [SerializeField] float walkSpeed = 1f;

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.right * walkSpeed * Time.deltaTime);
    }

    public void movmentSpeed(float moveSpeed)
    {
        walkSpeed = moveSpeed;
    }

}//defenderMovement
