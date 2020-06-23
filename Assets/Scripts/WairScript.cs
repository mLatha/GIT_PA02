using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WairScript : MonoBehaviour
{

    private float Wait;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Wait += 1 * Time.deltaTime;

        if(Wait >= 1)
        {
            Destroy(gameObject);
        }
    }
}
