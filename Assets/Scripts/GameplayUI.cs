using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;

public class GameplayUI : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public void BackBtnClicked()
    {
        SceneManager.LoadScene("MainMenuScene");
    }
}
