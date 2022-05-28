﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    // Start is called before the first frame update
    public void ExitButton() {
        Application.Quit();
        //Debug.Log("Game closed");
    }

    public void StartGame(string sceneName) {
        SceneManager.LoadScene(sceneName);

    }

    public void ChangeScene(string sceneName) {
        SceneManager.LoadScene(sceneName);
    }
}
