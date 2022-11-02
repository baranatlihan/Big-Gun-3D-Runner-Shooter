using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SideAssetSpawner : MonoBehaviour
{

    public GameObject objToSpawn;
    public float spawnTime;
    private float timer;
    private void Start()
    {
        timer = 0f;
        Instantiate(objToSpawn, transform.position, Quaternion.identity);
    }
    private void FixedUpdate()
    {
        timer += Time.deltaTime;
        if (timer > spawnTime)
        {
            timer = 0f;      
            Instantiate(objToSpawn, transform.position, Quaternion.identity);
        }
    }
}
