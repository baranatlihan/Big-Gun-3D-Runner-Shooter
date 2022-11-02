using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PistolMovement : MonoBehaviour
{
    private Joystick joystick;
    public float slideSpeed;


    private void Awake()
    {
        joystick = FindObjectOfType<Joystick>();
    }


    void Update()
    {
          if (joystick.Horizontal >= 0.1f && transform.position.x < 1.6f) 
          {
              transform.position += (Mathf.Abs(joystick.Horizontal)) * slideSpeed * Time.deltaTime * transform.right;
          }
          else if (joystick.Horizontal <= -0.1f && transform.position.x > -1.6f)
          {
              transform.position -= (Mathf.Abs(joystick.Horizontal)) * slideSpeed * Time.deltaTime * transform.right;
          }

    }
    
}
