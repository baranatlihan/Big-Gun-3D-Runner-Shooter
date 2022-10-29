using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Deactive : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log(other.tag);


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
