using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObectManager : MonoBehaviour
{
    //3 floor speed
    [Tooltip("3f floor speed")]
    public float flowSpeed;


    
    private int durability;
    private TextMesh durabilityTMesh;

    private void Start()
    {
        durabilityTMesh = GetComponent<TextMesh>();

        durability = Random.Range(4, 12) + Random.Range(0, 12);
        durabilityTMesh.text = durability.ToString();
    }


    private void Update()
    {

        if (GameManager.levelAction)
        {
            transform.position += -flowSpeed * Time.deltaTime * transform.forward;
        }
 

        if (durability <= 0 || !GameManager.levelAction)
        {
            transform.GetChild(1).gameObject.SetActive(false);
            transform.GetChild(0).gameObject.SetActive(true);

            GetComponent<BoxCollider>().enabled = false; // bug fix

            GetComponent<MeshRenderer>().enabled = false;
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

        }else if (other.CompareTag("Gun"))
        {
            GameManager.levelAction = false;
        }


    }



    IEnumerator BallHitCoroutine()
    {
        flowSpeed -= 1f;

         yield return new WaitForSeconds(0.1f);

        flowSpeed += 1f;
    }



}
