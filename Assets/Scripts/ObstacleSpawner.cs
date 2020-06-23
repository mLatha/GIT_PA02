﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//This script manages the spawning of obstacles
public class ObstacleSpawner : MonoBehaviour
{
    [SerializeField] private GameObject Obstacle1 = null;
    [SerializeField] private GameObject Obstacle2 = null;
    [SerializeField] private GameObject Obstacle3 = null;
    [SerializeField] private GameObject Obstacle4 = null;

    [SerializeField] private float SpawnInterval = 1;

    private int RandomValueToSpawn;

    private float NextSpawn = 0;

    void Update()
    {

        RandomValueToSpawn = Random.Range(0, 5);

        if(Time.time >= NextSpawn)
        {

            NextSpawn = Time.time + SpawnInterval;
            Vector3 SpawnPos = new Vector3(Random.Range(-1.5f, 1.5f), -4.85f, 22.7f);


            switch (RandomValueToSpawn)
            {
                case 1:
                    Instantiate(Obstacle1, SpawnPos, Quaternion.identity);
                    break;

                case 2:

                    Instantiate(Obstacle2, SpawnPos, Quaternion.identity);
                    break;

                case 3:
                    Instantiate(Obstacle3, SpawnPos, Quaternion.identity);
                    break;

                case 4:
                    Instantiate(Obstacle4, SpawnPos, Quaternion.identity);
                    break;


            }
        }
    }
}
