﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    public void LoadScene(string SceneName)
    {
        SceneManager.LoadScene(SceneName);
        SceneManager.GetSceneByName(SceneName);
    }

    public void Quit()
    {
        Application.Quit();
    }
}
