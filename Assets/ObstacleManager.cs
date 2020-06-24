using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleManager : MonoBehaviour
{
    public GameObject[] Obstacles;
    int i;
    float X;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnObjects", 1, 1);
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    void SpawnObjects()
    {
        X = Random.Range(-1.25f, 1.25f);
        this.transform.position = new Vector3(X, transform.position.y, transform.position.z);
        Instantiate(Obstacles[Random.Range(0, 3)], transform.position, transform.rotation);
    }
}
