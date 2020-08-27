using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Pausa : MonoBehaviour
{
    public static bool isPaused;

    public GameObject menuPausaUI;

    // Start is called before the first frame update
    void Start()
    {
        isPaused = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            if (isPaused)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }
    }

    public void Resume()
    {
        menuPausaUI.SetActive(false);
        Time.timeScale = 1f;
        isPaused = false;
    }

    private void Pause()
    {
        menuPausaUI.SetActive(true);
        Time.timeScale = 0f;
        isPaused = true;
    }

    public void MenuPrincipal()
    {
        ChangeScene.changeSceneInstance.LoadScene("FirstScene");
        Time.timeScale = 1f;
        isPaused = false;
    }

    public void Restart()
    {
        ChangeScene.changeSceneInstance.LoadScene("SecondScene");
        Time.timeScale = 1f;
        isPaused = false;
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
