using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    [SerializeField] GameObject pauseMenu;
    public static bool GameIsPaused = false;
    
    public void Pause()
    {
        pauseMenu.SetActive(true);
        GameIsPaused = true;
        Time.timeScale = 0f;
    }

    public void Resume()
    {
        pauseMenu.SetActive(false);
        GameIsPaused = false;
        Time.timeScale = 1f;
    }

    public void Restart()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("MenuScene");
    }
}