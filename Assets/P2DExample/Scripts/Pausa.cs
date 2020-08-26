using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Pausa : MonoBehaviour
{
    public static bool isPaused;
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

    private void Resume()
    {
        Time.timeScale = 1f;
        isPaused = false;
    }

    private void Pause()
    {
        Time.timeScale = 0f;
        isPaused = true;
    }
}
