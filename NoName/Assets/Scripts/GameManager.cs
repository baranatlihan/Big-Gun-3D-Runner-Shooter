using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    public static int currenScore;

    
    public static bool LightSwitchStatic;

    public static bool ballColorSwitchStatic;


    private void Awake()
    {
        currenScore = 0;
    }



}
