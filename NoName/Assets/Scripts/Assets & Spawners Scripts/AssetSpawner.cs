using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AssetSpawner : MonoBehaviour
{
    public GameObject[] spawnableObjects;
    public float spawnTime;
    private float timer;
    private Bounds bound;

    public bool startSpawn;

    ObjectPooler objectPooler;


    private void Start()
    {
        timer = 0;

        objectPooler = ObjectPooler.Instance;

        bound = new Bounds(transform.position, new Vector3(3f, 0, 6f));

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
        switch (Random.Range(1, 6))
        {
            case 0:
                break;

            case 1:
                objectPooler.SpawnFromPool("RedAsset", RandomPoint(bound), Quaternion.identity);
                break;

            case 2:
                objectPooler.SpawnFromPool("YellowAsset", RandomPoint(bound), Quaternion.identity);
                break;

            case 3:
                objectPooler.SpawnFromPool("GreenAsset", RandomPoint(bound), Quaternion.identity);
                break;

            case 4:
                objectPooler.SpawnFromPool("RedAsset", RandomPoint(bound), Quaternion.identity);
                objectPooler.SpawnFromPool("YellowAsset", RandomPoint(bound), Quaternion.identity);
                break;

            case 5:
                objectPooler.SpawnFromPool("YellowAsset", RandomPoint(bound), Quaternion.identity);
                objectPooler.SpawnFromPool("GreenAsset", RandomPoint(bound), Quaternion.identity);
                break;

            case 6:
                objectPooler.SpawnFromPool("RedAsset", RandomPoint(bound), Quaternion.identity);
                objectPooler.SpawnFromPool("GreenAsset", RandomPoint(bound), Quaternion.identity);
                break;
        }

    }

    public static Vector3 RandomPoint(Bounds bound)
    {
        return new Vector3(
        Random.Range(bound.min.x, bound.max.x),
        Random.Range(bound.min.y, bound.max.y),
        Random.Range(bound.min.z, bound.max.z)
        );
    }
}
