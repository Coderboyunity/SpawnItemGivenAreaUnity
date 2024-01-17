using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject SpawnObjecte;
    public bool stopSpawning = false;
    public float spawnTime;
    public float spawnDelay;

    void Start()
    {
        InvokeRepeating("SpawnObject", spawnTime, spawnDelay);
    }

    public void SpawnObject()
    {
        float offsetX = Random.Range(-5f, 5f);
        float offsetY = Random.Range(-5f, 5f);
        Vector3 randomOffset = new Vector3(offsetX, offsetY, 0f);

        Instantiate(SpawnObjecte, transform.position + randomOffset, transform.rotation);

        if (stopSpawning)
        {
            CancelInvoke("SpawnObject");
        }
    }
}

