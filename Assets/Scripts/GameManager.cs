using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;

public class GameManager : MonoBehaviour
{
    public float Timer;
    public bool HasWon;
    public int TapCount;
    public int TargetCount;
    public bool TimerHasEnded;
    public static int HighScore;
    public GameplayUI gamePlayUI;
    public float CountDownTimer;
    public bool CountDownTimerHasEnded;
    public float DefaultTimerValue = 5;

    void Start()
    {
        CountDownTimer = 3;
        CountDownTimerHasEnded = false;
        GetHighScore();
        Timer = DefaultTimerValue;
    }

    // Update is called once per frame
    void Update() {
        if(!CountDownTimerHasEnded)
        {
            CountDownTimer -= Time.deltaTime;
            if(CountDownTimer<=0)
            {
                CountDownTimerHasEnded = true;
                gamePlayUI.DisableCountDownTimer();
            }
        }
        gamePlayUI.ShowHighScoreText();
        if(CountDownTimerHasEnded && !TimerHasEnded)
        {
            Timer -= Time.deltaTime;
            if(Timer<=0)
            {
                TimerHasEnded = true;
                Timer = 0;
                HasWon = TapCount > TargetCount ? true : false;
                HighScore = TapCount > HighScore ? TapCount : HighScore;
                SaveHighScore();
                gamePlayUI.ShowGameOverOrWin();
            }
            if(!gamePlayUI.isPaused && Input.GetMouseButtonDown(0))
            {
                TapCount++;
                gamePlayUI.UpdateTapCountText();
            }
        }
    }

    public void SaveHighScore()
    {
        PlayerPrefs.SetInt("HighScore", HighScore);
    }

    public void GetHighScore()
    {
        HighScore = PlayerPrefs.GetInt("HighScore");
    }
}
