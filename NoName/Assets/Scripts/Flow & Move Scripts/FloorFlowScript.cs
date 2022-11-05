using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloorFlowScript : MonoBehaviour
{

    public float scrollSpeed = -0.25f;
    Renderer rend;
    void Start()
    {
        rend = GetComponent<Renderer>();
    }


    void Update()
    {
        float offset = Time.time * scrollSpeed;
        rend.material.SetTextureOffset("_MainTex", new Vector2(0, offset));
    }
}
