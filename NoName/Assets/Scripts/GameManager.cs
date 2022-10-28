using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    public static int currenScore;



    
    public static bool LightSwitchStatic;
    public bool lightSwitch;



    public static bool ballColorSwitchStatic;
    public bool ballColorSwitch;


    private void Start()
    {
        LightSwitchStatic = lightSwitch;
        ballColorSwitchStatic = ballColorSwitch;
    }

    private void Update()
    {
        LightSwitchStatic = lightSwitch;
        ballColorSwitchStatic = ballColorSwitch;

    }


}
