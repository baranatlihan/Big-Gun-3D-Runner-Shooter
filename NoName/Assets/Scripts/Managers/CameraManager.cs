using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraManager : MonoBehaviour
{
    public GameObject TargetPlayer;
    private Transform target;

    private Vector3 startPos;
    void Start()
    {
        target = TargetPlayer.transform;
        startPos = transform.position;

    }

    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = new Vector3(target.position.x + startPos.x, target.position.y + startPos.y, target.position.z + startPos.z);
    }
}
