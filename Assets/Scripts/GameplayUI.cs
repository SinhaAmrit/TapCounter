using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;

public class GameplayUI : MonoBehaviour
{

    public GameObject TapCountText;
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
        TapCountText.GetComponent<Text>().text = gameManager.tapCount.ToString();
    }

    public void BackBtnClicked()
    {
        SceneManager.LoadScene("MainMenuScene");
    }
}
