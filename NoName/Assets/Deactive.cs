using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Deactive : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        other.tag = "Destroyed";


        if(other.CompareTag("Little Boxes")) 
            { 
                Destroy(other.gameObject);
            }
            else
            {
                other.gameObject.SetActive(false);
            }

    }
}
