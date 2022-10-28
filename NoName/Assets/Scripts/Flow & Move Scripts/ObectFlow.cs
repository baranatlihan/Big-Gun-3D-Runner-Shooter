using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObectFlow : MonoBehaviour
{
    //1.5 floor speed
    [Tooltip("1.5f floor speed")]
    public float flowSpeed;

    private bool ballHit;

    private void Start()
    {
        ballHit = false;
    }
    private void FixedUpdate()
    {

        if (!ballHit)
        {
            transform.position += -flowSpeed * Time.deltaTime * transform.forward;
        }
           

        


    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Ball") && ballHit == false)
        {
            StartCoroutine(BallHitCoroutine());        
        }
    }

    IEnumerator BallHitCoroutine()
    {
        ballHit = true;


        yield return new WaitForSeconds(0.4f);

        ballHit = false;
    }



}
