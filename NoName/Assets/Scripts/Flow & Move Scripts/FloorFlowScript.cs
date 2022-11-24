using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloorFlowScript : MonoBehaviour
{

    public float scrollSpeed;
    Renderer rend;
    void Start()
    {
        rend = GetComponent<Renderer>();
    }


    void Update()
    {

        if (GameManager.levelAction)
        {
            float offset = Time.time * scrollSpeed;
            rend.material.SetTextureOffset("_MainTex", new Vector2(0, offset));
        }

    }
}
