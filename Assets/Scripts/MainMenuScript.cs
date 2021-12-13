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
    public GameObject SettingsBtn;
    public AudioSource gameAudio;
    public AudioClip clip;
    public Animator sttingsAnimator;

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
        SettingsBtn.SetActive(false);
        sttingsAnimator.SetTrigger("Slide-In");
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
        sttingsAnimator.SetTrigger("Slide-Out");
        MainMenu.SetActive(true);
        StartCoroutine("DisableSettingsPanel");
        HowToPlay.SetActive(false);
        Credits.SetActive(false);
    }
    public IEnumerator DisableSettingsPanel()
    {
        yield return new WaitForSeconds(1);
        Settings.SetActive(false);
        SettingsBtn.SetActive(true);
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
