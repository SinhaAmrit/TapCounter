using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;

public class GameManager : MonoBehaviour
{
    public int tapCount;
    public GameplayUI gamePlayUI;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update() {
        if(Input.GetMouseButtonDown(0))
        {
            tapCount++;
            gamePlayUI.UpdateTapCountText();
        }
    }
}
