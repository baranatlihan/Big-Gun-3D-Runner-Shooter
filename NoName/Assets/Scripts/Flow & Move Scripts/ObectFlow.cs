using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObectFlow : MonoBehaviour
{

    public float flowSpeed;

    private void FixedUpdate()
    {
        if (!gameObject.CompareTag("insertedBox"))
        {
            transform.position += flowSpeed * Time.deltaTime * transform.forward;
        }

    }
}
