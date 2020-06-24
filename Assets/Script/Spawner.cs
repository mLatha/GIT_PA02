using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject[] StuffSpawn;
    private float spawntime = 1;
    private float spawnDelay = 1;
    private int randomint;
    float posx;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("spawnobject", spawntime, spawnDelay);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void spawnobject()
    {
        randomint = Random.Range(0, StuffSpawn.Length);
        posx = Random.Range(1.5f, -1.5f);
        this.transform.position = new Vector3(posx, transform.position.y, transform.position.z);
        Instantiate(StuffSpawn[randomint], transform.position, transform.rotation);
    }
}
