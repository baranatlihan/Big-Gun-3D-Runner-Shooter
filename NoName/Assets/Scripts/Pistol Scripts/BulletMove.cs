using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletMove : MonoBehaviour, IPooledObject
{
    public float bulletSpeed = 10f;

    public float upForce = .1f;
    public float sideForce = .1f;

    private float timer;

    public void OnObjectSpawn()
    {
        if (GameManager.ballColorSwitchStatic)
        {
            newColor();
        }
        else
        {
            GetComponent<MeshRenderer>().material.color = Color.white;

        }


        timer = 0;
        float xForce = Random.Range(-sideForce, sideForce);
        float yForce = Random.Range(upForce, upForce / 2);

        Vector3 force = new Vector3(xForce, yForce, bulletSpeed);

        GetComponent<Rigidbody>().velocity = force;
    }


    private void Update()
    {

        #region optimization?
        timer += Time.deltaTime;
        if (timer > 2)
        {
            this.gameObject.SetActive(false);
        }
        #endregion

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Little Boxes"))
        {
            other.GetComponent<Rigidbody>().AddForce(new Vector3(0f,10f,0f), ForceMode.VelocityChange);
            Destroy(other.gameObject,3);
        }
    }


    public void newColor()
    {
        Color col = new Color(
      Random.Range(0f, 1f),
      Random.Range(0f, 1f),
      Random.Range(0f, 1f),
      1f

  );
        GetComponent<MeshRenderer>().material.color = col;
    }

}
