using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    public static int currenScore;

    [Header("Level end with time settings")]
    [Tooltip("end level time")]
    [SerializeField]
    private float levelTime;
    static public float levelTimeStatic;
    public static float timer;
    public static bool levelAction;
    public static bool levelEndSucces;
    public static Joystick joystick;
    [SerializeField]
    private bool timeEnd;

    [Tooltip("About Enverioment variables")]
    public static bool LightSwitchStatic;
    public static bool ballColorSwitchStatic;



    private void Awake()
    {
        Time.timeScale = 0;

        currenScore = 0;
        timer = 0;  //level time timer
        levelEndSucces = false;
        joystick = FindObjectOfType<Joystick>();
    }

    private void Start()
    {
        levelAction = true;
        levelTimeStatic = levelTime;

    }

    private void Update()
    {
        timer += Time.deltaTime;


        if (levelTime < timer && timeEnd)
        {
            levelEndSucces = true;
            levelAction = false;
        }
    }


}
