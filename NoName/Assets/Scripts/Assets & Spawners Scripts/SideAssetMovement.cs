using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SideAssetMovement : MonoBehaviour
{
    private Vector3 startPos;
    private void Start()
    {
        startPos = transform.position;
    }

    private void FixedUpdate()
    {
        transform.position += Time.deltaTime * 3f * transform.right;

        if (Vector3.Distance(startPos, transform.position)>16f)
        {
            Destroy(gameObject);
        }
    }
}
