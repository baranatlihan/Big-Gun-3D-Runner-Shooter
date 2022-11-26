using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FakeExplodeScript : MonoBehaviour
{

    void Start()
    {
        GetComponent<Rigidbody>().AddForce(new Vector3(Random.Range(-6f, 6f), 10f, Random.Range(-6f, 6f)), ForceMode.VelocityChange);
        GameManager.currenScore+=5;
    }

}
