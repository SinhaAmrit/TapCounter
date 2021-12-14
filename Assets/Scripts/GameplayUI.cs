using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;

public class GameplayUI : MonoBehaviour
{
    public GameObject TapCountText;
    public GameObject GameOverPanel;
    public GameObject ResumePanel;
    public GameObject WinPanel;
    public Text TimerText;
    public bool isPaused;
    public Text HighScoreText;
    public GameManager gameManager;
    public Text CountDownTimerText;

    void Start(){}
      public void Update()
    {
        CountDownTimerText.text = gameManager.CountDownTimer.ToString("N0");
        TimerText.text = gameManager.Timer.ToString("N");
    }

    public void DisableCountDownTimer()
    {
        CountDownTimerText.gameObject.SetActive(false);
        TapCountText.gameObject.SetActive(true);
    }

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

    public void MainMenu()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("MainMenuScene");
    }

    public void Pause()
    {
        CountDownTimerText.gameObject.SetActive(false);
        ResumePanel.SetActive(true);
        isPaused = true;
        Time.timeScale = 0;
    }

    public void Resume(){
        isPaused = false;
        ResumePanel.SetActive(false);
        if(!gameManager.CountDownTimerHasEnded)
        CountDownTimerText.gameObject.SetActive(true);
        Time.timeScale = 1;
    }
}
