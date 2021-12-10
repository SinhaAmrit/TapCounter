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
    public float DefaultTimerValue = 5;

    // Start is called before the first frame update
    void Start()
    {
        GetHighScore();
        Timer = DefaultTimerValue;
    }

    // Update is called once per frame
    void Update() {;
        gamePlayUI.ShowHighScoreText();
        gamePlayUI.ShowTimerText();
        if(!TimerHasEnded){
            Timer -= Time.deltaTime;
            if(Timer<=0){
                TimerHasEnded = true;
                Timer = 0;
                HasWon = TapCount > TargetCount ? true : false;
                HighScore = TapCount > HighScore ? TapCount : HighScore;
                SaveHighScore();
                gamePlayUI.ShowGameOverOrWin();
                
                Debug.Log(HighScore);
            }
            if(Input.GetMouseButtonDown(0))
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
