using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletSpawner : MonoBehaviour
{

    private float spawnTimer;
    public float fireRate = 15f;

    ObjectPooler objectPooler;


    private void Start()
    {
        objectPooler = ObjectPooler.Instance;
        spawnTimer = 0f;

    }

    private void Update()
    {
        spawnTimer += Time.deltaTime;

        if(spawnTimer >  1/ fireRate && GameManager.levelAction)
        {
            objectPooler.SpawnFromPool("Ball", transform.position, Quaternion.identity);
            spawnTimer = 0;
        }
    }

}
