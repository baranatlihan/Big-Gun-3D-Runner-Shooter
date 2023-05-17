using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class testForce : MonoBehaviour
{
    public float bulletSpeed = 25f;



    void Start()
    {
        Vector3 force = new Vector3(0, 0, bulletSpeed);
        GetComponent<Rigidbody>().velocity = force;

    }

}
