using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletMove : MonoBehaviour
{
    public float bulletSpeed = 5;
    private Vector3 startPos;


    private void FixedUpdate()
    {
        if(transform.position.z - startPos.z < 6)
        {
            transform.position += bulletSpeed * Time.deltaTime * transform.forward;
        }
        else
        {
            transform.position = transform.parent.position;
        }
    }

}
