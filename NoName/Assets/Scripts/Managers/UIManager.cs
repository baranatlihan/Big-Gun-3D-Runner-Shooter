using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    [Header("Right Top")]
    public GameObject timeText;
    public GameObject scoreText;


    [Header("Mid Panels")]
    public GameObject gameOverPanel;
    public GameObject levelEndPanel;
    public GameObject tapToStartText;
    public static GameObject tapToStartTextStatic;

    [Header("Left Top")]
    public GameObject pauseButton;
    public GameObject resumeButton;

    private void Awake()
    {
        gameOverPanel.SetActive(false);

    }

    private void Start()
    {
        tapToStartTextStatic = tapToStartText;


    }

    private void Update()
    {
        if (GameManager.levelAction)
        {
            timeText.GetComponent<TextMeshProUGUI>().text = "Time: " + (GameManager.levelTimeStatic-(int)GameManager.timer);
            scoreText.GetComponent<TextMeshProUGUI>().text = "Score: " + GameManager.currenScore;
        }
        else
        {
            void setFalseElements()
            {
                timeText.SetActive(false);
                scoreText.SetActive(false);
                resumeButton.SetActive(false);
                pauseButton.SetActive(false);
            }

            setFalseElements();

            if (GameManager.levelEndSucces)
            {
                levelEndPanel.SetActive(true);
                GameManager.timer = 0;
            }
            else
            {
                gameOverPanel.SetActive(true);
                GameManager.timer = 0;
            }
        }
    }



    public void RestartButton()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void QuitButton()
    {
        Application.Quit();
    }

    public void MainMenuButton()
    {
        //SceneManager.LoadScene(0);
    }

    public void PauseResumeButton()
    {
        if (Time.timeScale == 1)
        {
            resumeButton.SetActive(true);
            pauseButton.SetActive(false);
            Time.timeScale = 0;
        }
        else
        {
            Time.timeScale = 1;
            pauseButton.SetActive(true);
            resumeButton.SetActive(false);
        }
    }






    public void NextLevelButton()
    {
        /*if (SceneManager.GetActiveScene().buildIndex + 1 == 0)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 2);
        }
        else
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }*/
    }




}
