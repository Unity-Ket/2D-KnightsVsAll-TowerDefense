﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Golem1 : MonoBehaviour
{
    [Range(0f, 10f)] [SerializeField] float walkSpeed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.left * walkSpeed * Time.deltaTime);
    }
}