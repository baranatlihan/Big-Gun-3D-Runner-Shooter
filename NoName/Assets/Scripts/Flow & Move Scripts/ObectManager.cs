using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObectManager : MonoBehaviour
{
    //1.5 floor speed
    [Tooltip("1.5f floor speed")]
    public float flowSpeed;


    
    private int durability;
    private TextMesh durabilityTMesh;

    private void Start()
    {
        durabilityTMesh = GetComponent<TextMesh>();

        durability = Random.Range(8, 24) + Random.Range(0, 12);
        durabilityTMesh.text = durability.ToString();
    }


    private void FixedUpdate()
    {

        transform.position += -flowSpeed * Time.deltaTime * transform.forward;


        if (durability <= 0)
        {
            transform.GetChild(1).gameObject.SetActive(false);
            transform.GetChild(0).gameObject.SetActive(true);
            GetComponent<MeshRenderer>().enabled = false;
            //score ++ !
        }
    }


    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Ball"))
        {
            if (!transform.GetChild(0).gameObject.activeInHierarchy)
            {
                StartCoroutine(BallHitCoroutine());
            }

            durability--;
            durabilityTMesh.text = durability.ToString();
        }
    }



    IEnumerator BallHitCoroutine()
    {
        flowSpeed -= 0.5f;

         yield return new WaitForSeconds(0.1f);

        flowSpeed += 0.5f;
    }



}
