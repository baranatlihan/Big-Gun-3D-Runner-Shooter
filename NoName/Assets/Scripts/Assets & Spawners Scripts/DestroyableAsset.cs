using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class DestroyableAsset : MonoBehaviour
{

    public Color color;
    public int durability;

    private void Awake()
    {

        GetComponent<MeshRenderer>().material.color = color;
        durability = Random.Range(10, 50) + Random.Range(1, 8);
        Debug.Log(durability);

    }


    private void Start()
    {

    }



}
