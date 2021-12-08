using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;

public class MainMenuScript : MonoBehaviour
{

    public GameObject MainMenu;
    public GameObject Settings;
    public GameObject HowToPlay;
    public GameObject Credits;

    // Start is called before the first frame update
    void Start()
    {
        MainMenu.SetActive(true);
        Settings.SetActive(false);
        HowToPlay.SetActive(false);
        Credits.SetActive(false);
    }
    public void SettingsBtnClicked()
    {
        Settings.SetActive(true);
        MainMenu.SetActive(false);
    }
    public void HowToPlayBtnClicked()
    {
        HowToPlay.SetActive(true);
        MainMenu.SetActive(false);
    }
    public void CreditsBtnClicked()
    {
        Credits.SetActive(true);
        MainMenu.SetActive(false);
    }
    public void BackBtnClicked() 
    {
        MainMenu.SetActive(true);
        Settings.SetActive(false);
        HowToPlay.SetActive(false);
        Credits.SetActive(false);
    }
    public void PlayBtnClicked()
    {
        SceneManager.LoadScene("GameplayScene");
    }
}
