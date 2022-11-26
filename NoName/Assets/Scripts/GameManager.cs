using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    public static int currenScore;


    [Tooltip("Flow end level time")]
    [SerializeField]
    private float levelTime;
    static public float levelTimeStatic;
    public static float timer;
    public static bool levelAction;
    public static Joystick joystick;

    [Tooltip("About Enverioment variables")]
    public static bool LightSwitchStatic;
    public static bool ballColorSwitchStatic;


    private void Awake()
    {
        currenScore = 0;
        timer = 0;  //level time timer
        levelAction = true;

        joystick = FindObjectOfType<Joystick>();
    }

    private void Start()
    {
        levelTimeStatic = levelTime;
    }

    private void Update()
    {
        timer += Time.deltaTime;


        if (levelTime < timer)
        {
            levelAction = false;
        }
    }


}
