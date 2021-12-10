using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;

public class GameManager : MonoBehaviour
{
    public int TapCount;
    public int TargetCount;
    public GameplayUI gamePlayUI;
    public float DefaultTimerValue = 5;
    public float Timer;
    public bool TimerHasEnded;
    public bool HasWon;

    // Start is called before the first frame update
    void Start()
    {
        Timer = DefaultTimerValue;
    }

    // Update is called once per frame
    void Update() {
        gamePlayUI.UpdateTimerText();
        if(!TimerHasEnded){
            Timer -= Time.deltaTime;
            if(Timer<=0){
                TimerHasEnded = true;
                Timer = 0;
                if(TapCount > TargetCount) HasWon = true;
                gamePlayUI.ShowGameOverOrWin();
                Debug.Log("Timer Has Ended "+ HasWon.ToString());
            }
            if(Input.GetMouseButtonDown(0))
            {
                TapCount++;
                gamePlayUI.UpdateTapCountText();
            }
        }
    }
}
