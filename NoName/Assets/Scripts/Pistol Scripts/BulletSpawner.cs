using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletSpawner : MonoBehaviour
{

    private float timer;
    public float fireRate;

    ObjectPooler objectPooler;

    private void Start()
    {
        objectPooler = ObjectPooler.Instance;
        timer = 0f;
    }

    private void FixedUpdate()
    {
        timer += Time.deltaTime;

        if(timer >  1/ fireRate)
        {
            objectPooler.SpawnFromPool("Ball", transform.position, Quaternion.identity);
            timer = 0;
        }
    }

}
