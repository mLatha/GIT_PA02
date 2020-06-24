﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacles : MonoBehaviour
{
    [SerializeField] private int Hitpoints = 3;
    [SerializeField] private bool RandomRotation = false;
    public GameObject Explosion;
    public float delay = 1; 

    private void Start()
    {
        if(RandomRotation)
            transform.eulerAngles = new Vector3(Random.Range(0, 180), Random.Range(0, 180), Random.Range(0, 180));
    }

    void Update()
    {
        transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z - ( 8 * 2 * Time.deltaTime));

        if(transform.position.z <= -8)
        {
            Destroy(gameObject);
            GameManager.Score++;
            HUD.HUDManager.UpdateScore();
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            GameManager.Lives--;
            HUD.HUDManager.UpdateLives();

            GameObject Boom = Instantiate(Explosion, Vector3.zero, Quaternion.identity);
            Destroy(Boom, 0.8f);

            if(GameManager.Lives <= 0)
            {
                HUD.HUDManager.GameOver();
            }
        }
    }
}
