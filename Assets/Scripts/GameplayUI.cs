using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;

public class GameplayUI : MonoBehaviour
{

    public GameObject TapCountText;
    public GameObject GameOverPanel;
    public GameObject WinPanel;
    public Text TimerText;
    public Text HighScoreText;
    public GameManager gameManager;

    void Start(){}
    public void ShowTimerText()
    {
        TimerText.GetComponent<Text>().text = gameManager.Timer.ToString();
    }

    public void ShowHighScoreText()
    {
        HighScoreText.GetComponent<Text>().text = GameManager.HighScore.ToString();
    }

    public void UpdateTapCountText()
    {
        TapCountText.GetComponent<Text>().text = gameManager.TapCount.ToString();
    }

    public void BackBtnClicked()
    {
        SceneManager.LoadScene("MainMenuScene");
    }

    public void ShowGameOverOrWin()
    {
        if(gameManager.HasWon)  WinPanel.SetActive(true);
        else GameOverPanel.SetActive(true);
    }

    public void RestartGame()
    {
        SceneManager.LoadScene("GamePlayScene");
    }
}
