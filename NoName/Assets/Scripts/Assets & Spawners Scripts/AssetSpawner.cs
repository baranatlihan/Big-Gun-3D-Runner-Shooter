using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AssetSpawner : MonoBehaviour
{
    public GameObject[] spawnableObjects;
    public float spawnTime;
    private float timer;
    private Vector3 spawnPoint;

    private void Start()
    {
        timer = 0;
        spawnPoint = transform.position;
    }

    private void Update()
    {
        timer += Time.deltaTime;
        if (timer > spawnTime)
        {
            SpawnObj();
            timer = 0;
        }
    
    }

    public void SpawnObj()
    {

        Instantiate(spawnableObjects[Random.Range(0, spawnableObjects.Length)], 
            spawnPoint + new Vector3(Random.Range(-1.5f, 1.5f), 0f,Random.Range(-1.5f, 1.5f)), 
            Quaternion.identity);

    }
}
