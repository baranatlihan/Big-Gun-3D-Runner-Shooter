using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class DestroyableAsset : MonoBehaviour
{

    public Color color;
 

    private void Awake()
    {

        GetComponent<MeshRenderer>().material.color = color;


    }




}
