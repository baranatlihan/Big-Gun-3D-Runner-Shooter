using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    public GameObject timeText;
    public GameObject scoreText;

    public GameObject gameOverPanel;
    public GameObject levelEndPanel;
    private void Awake()
    {
        gameOverPanel.SetActive(false);
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
            timeText.SetActive(false);
            scoreText.SetActive(false);
            //if gamemanager levelend bool ---> if true level end, else game over misali
            gameOverPanel.SetActive(true);
        }
    }



    public void RestartButton()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void MainMenuButton()
    {

    }

}
