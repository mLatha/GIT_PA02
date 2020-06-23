﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//This script manages the behavior of individual obstacle
public class Obstacle : MonoBehaviour
{
    [SerializeField] private float Speed = 3;

    void Update()
    {
        if (transform.position.z <= -8.5f)
        {
            Player.Score += 1;
            Destroy(gameObject);
        }

        else
            transform.Translate(Vector3.forward * Time.deltaTime * -Speed);
    }
}
