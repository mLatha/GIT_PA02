using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleSpawn : MonoBehaviour
{
    public GameObject[] Obstacles;

    private float spawnDelay = 1;
    // Start is called before the first frame update
    void Start()
    {
        Obstacles = Random.Range(1, 4);
        InvokeRepeating("Spawn", spawnDelay, spawnDelay);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void Spawn()
    {
        var O = GameObject.Instantiate(Obstacles);
    }
}
