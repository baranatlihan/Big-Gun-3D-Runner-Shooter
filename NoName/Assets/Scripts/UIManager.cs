using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    public GameObject timeText;
    private float timer;
    
    public GameObject scoreText;


    private void Start()
    {
        timer = 0f;
    }

    private void Update()
    {
        timer += Time.deltaTime;
        timeText.GetComponent<TextMeshProUGUI>().text = "Time: " + (int)timer;
    }

}
