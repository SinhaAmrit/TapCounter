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
    public GameManager gameManager;

    // Start is called before the first frame update
    void Start()
    {
        
    }
    public void UpdateTimerText()
    {
        TimerText.GetComponent<Text>().text = gameManager.Timer.ToString();
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
}
