using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class PuntajeCreditos : MonoBehaviour
{

    public Text contTiempo;
    public Text contScore;
    public Text contPowerUps;


    // Start is called before the first frame update
    void Start()
    {
        

    }

    // Update is called once per frame
    void Update()
    {
        SetCountText();
    }

    void SetCountText()
    {
        contTiempo.text = "" + PlayerPrefs.GetFloat("tiempo").ToString("F2");
        contScore.text = "" + PlayerPrefs.GetInt("score");
        contPowerUps.text = "" + PlayerPrefs.GetInt("powerUps");

    }
}
