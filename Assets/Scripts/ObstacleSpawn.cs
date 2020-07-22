using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleSpawn : MonoBehaviour
{
    public GameObject[] Obstacles;

    private float spawnDelay = 1;
    private float spawnTime = 1;

    private int RandomInt;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Spawn", spawnTime, spawnDelay);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void Spawn()
    {
        RandomInt = Random.Range(1, Obstacles.Length);
        this.transform.position = new Vector3(Random.Range(-2, 2), 0, -2);
        Instantiate(Obstacles[RandomInt], transform.position, transform.rotation);
    }
}
