using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimedSpawn : MonoBehaviour
{
    public GameObject spawn;
    public bool stopSpawn = false;
    public float spawnTime ;
    public float spawnDelay ;
    
    // Start is called before the first frame update
    void Start()
    {
        //SpawnObject();
        InvokeRepeating("SpawnObject", spawnTime, spawnDelay);
    }

    public void SpawnObject()
    {
       Instantiate(spawn, transform.position, transform.rotation);
        if (stopSpawn)
        {
            CancelInvoke("SpawnObject");
        }
    }

}
