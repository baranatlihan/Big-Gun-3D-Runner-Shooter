using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class setColorParts : MonoBehaviour
{
    void Awake()
    {
        for (int i = 0; i < transform.childCount; i++)
        {
            transform.GetChild(i).GetComponent<MeshRenderer>().material.color
                =
                transform.parent.GetChild(1).GetComponent<DestroyableAsset>().color;
        }
    }

    private void Start()
    {
        gameObject.SetActive(false);

    }



}
