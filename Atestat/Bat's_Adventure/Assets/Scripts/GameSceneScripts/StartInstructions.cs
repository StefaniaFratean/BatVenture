using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartInstructions : MonoBehaviour
{

    public bool waitForStart = true;
    public GameObject starInstructionsUI;

    void Update()
    {
        if (waitForStart == true)
        {
            Pause();
            Time.timeScale = 0f;
        }
        

        if (Input.GetKeyDown(KeyCode.Space))
        {
                Resume();
            waitForStart = false;
        }
    }

    public void Resume()
    {
        starInstructionsUI.SetActive(false);
        Time.timeScale = 1f;
    }

    void Pause()
    {
        starInstructionsUI.SetActive(true);
        Time.timeScale = 0f;
    }

}
