using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChange : MonoBehaviour
{
    private Light _light;
    private Color normalCol;


    private int score;
    void Start()
    {
        score = 0;
        _light = GetComponent<Light>();
        normalCol = _light.color;


        score = GameManager.currenScore;


    }

    // Update is called once per frame
    void Update()
    {

        if (GameManager.LightSwitchStatic)
        {
            _light.color = Color.red;
        }
        else
        {
            _light.color = normalCol;
        }
        




    }




}
