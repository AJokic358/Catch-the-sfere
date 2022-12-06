using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenu : MonoBehaviour
{
    public GameObject pauseButton;
    public GameObject resumeButton;

    public void Pause()
    {
        pauseButton.SetActive(true);
        Time.timeScale = 0f;
    }
    public void Resume()
    {
        resumeButton.SetActive(true);
        Time.timeScale = 1f;

    }
}
