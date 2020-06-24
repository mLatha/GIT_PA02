using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleSpawner : MonoBehaviour
{
    public GameObject[] obstacles;
    public Vector3 spawnValues;
    public float spawnDelay;
    public float spawnMaxDelay;
    public float spawnMinDelay;
    public int startDelay;
    public bool stop;
    private int randObstacles;


    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Spawner());
    }

    // Update is called once per frame
    void Update()
    {
        spawnDelay = Random.Range(spawnMinDelay, spawnMaxDelay);
    }

    IEnumerator Spawner()
    {
        yield return new WaitForSeconds(startDelay);

        while (!stop)
        {
            randObstacles = Random.Range(0, 4);
            Vector3 spawnPosition = new Vector3(Random.Range(-spawnValues.x, spawnValues.x), 1, Random.Range(-spawnValues.z, spawnValues.z));
            Instantiate(obstacles[randObstacles], spawnPosition + transform.TransformPoint(0, 0, 0), gameObject.transform.rotation);

            yield return new WaitForSeconds(spawnDelay);
        }
    }
}
