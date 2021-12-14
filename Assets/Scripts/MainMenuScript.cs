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
    public GameObject FadePanel;
    public AudioSource gameAudio;
    public AudioClip clip;
    public Animator settingsAnimator;

    // Start is called before the first frame update
    void Start()
    {
        FadeIn();
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
        settingsAnimator.SetTrigger("Slide-In");
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
        settingsAnimator.SetTrigger("Slide-Out");
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
        FadeOut();
        StartCoroutine("LoadLevelWithDelay");
    }

    IEnumerator LoadLevelWithDelay()
    {
        yield return new WaitForSeconds(.5f);
        SceneManager.LoadScene("GameplayScene");
    }

    public void PlayButtonSound()
    {
        gameAudio.PlayOneShot(clip);
    }

    void FadeIn()
    {
        FadePanel.GetComponent<Animator>().SetTrigger("Fade-In");
    }

    void FadeOut()
    {
        FadePanel.GetComponent<Animator>().SetTrigger("Fade-Out");
    }
}
