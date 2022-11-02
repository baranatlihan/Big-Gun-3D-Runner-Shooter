using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpecialObjectManager : MonoBehaviour
{

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Ball"))
        {
            GetComponent<MeshRenderer>().enabled = false;
            GetComponent<SphereCollider>().enabled = false;

            StartCoroutine(ColorBallCoroutine());
        }

    }
           
    IEnumerator ColorBallCoroutine()
    {
        GameManager.ballColorSwitchStatic = true;
        BulletSpawner.fireRate = 50f;

        yield return new WaitForSeconds(3.0f);

        BulletSpawner.fireRate = 15f;
        GameManager.ballColorSwitchStatic = false;
        Destroy(gameObject);
    }

}
