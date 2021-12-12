using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;

public class MainMenuScript : MonoBehaviour
{
    public GameObject Credits;
    public GameObject MainMenu;
    public GameObject Settings;
    public GameObject HowToPlay;
    public AudioSource gameAudio;
    public AudioClip clip;

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
        PlayButtonSound();
        Settings.SetActive(true);
        MainMenu.SetActive(false);
    }

    public void HowToPlayBtnClicked()
    {
        PlayButtonSound();
        HowToPlay.SetActive(true);
        MainMenu.SetActive(false);
    }

    public void CreditsBtnClicked()
    {
        PlayButtonSound();
        Credits.SetActive(true);
        MainMenu.SetActive(false);
    }

    public void BackBtnClicked() 
    {
        PlayButtonSound();
        MainMenu.SetActive(true);
        Settings.SetActive(false);
        HowToPlay.SetActive(false);
        Credits.SetActive(false);
    }

    public void PlayBtnClicked()
    {
        PlayButtonSound();
        SceneManager.LoadScene("GameplayScene");
    }

    public void PlayButtonSound()
    {
        gameAudio.PlayOneShot(clip);
    }
}
