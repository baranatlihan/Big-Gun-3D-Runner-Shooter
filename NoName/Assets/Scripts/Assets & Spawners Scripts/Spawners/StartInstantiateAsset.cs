using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartInstantiateAsset : MonoBehaviour
{
    public GameObject[] spawnObjs;

    private Bounds bound;
    void Start()
    {
        bound = new Bounds(new Vector3(0, 0.3125f, 16f), new Vector3(2f, 0, 12f));

        for (int i = 0; i < 4; i++)
        {

            Instantiate(spawnObjs[Random.Range(0, spawnObjs.Length)], RandomPoint(bound), Quaternion.identity);

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
