using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public static bool GameIsPaused = false;

    public GameObject PauseWindowUI;

    public Button LeaveGame;
    public Button MenuReturn;

    public GameObject GunPaused;
    public GameObject PausedCompass;
    public GameObject PausedCrosshair;
    public GameObject PausedHealthIcon;
    public GameObject PausedHealthValue;
    public GameObject PausedTimer;
    public GameObject PausedSteelCounter;

    void Start()
    {
        PauseWindowUI.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
        GunPaused.SetActive(true);
        PausedCompass.SetActive(true);
        PausedCrosshair.SetActive(true);
        PausedHealthIcon.SetActive(true);
        PausedHealthValue.SetActive(true);
        PausedTimer.SetActive(true);
        PausedSteelCounter.SetActive(true);
        
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (GameIsPaused)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }
    }

    void Resume()
    {
        PauseWindowUI.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
        GunPaused.SetActive(true);
        PausedCompass.SetActive(true);
        PausedCrosshair.SetActive(true);
        PausedHealthIcon.SetActive(true);
        PausedHealthValue.SetActive(true);
        PausedTimer.SetActive(true);
        PausedSteelCounter.SetActive(true);
    }

    void Pause()
    {
        PauseWindowUI.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true;
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
        GunPaused.SetActive(false);
        PausedCompass.SetActive(false);
        PausedCrosshair.SetActive(false);
        PausedHealthIcon.SetActive(false);
        PausedHealthValue.SetActive(false);
        PausedTimer.SetActive(false);
        PausedSteelCounter.SetActive(false);
    }

    public void Quit()
    {
        Application.Quit();
    }

    public void Return()
    {
        SceneManager.LoadScene("MainMenu");
    }

}
