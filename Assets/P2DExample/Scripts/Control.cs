﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Control : MonoBehaviour
{
    public float tiempo;
    public int score;
    public int powerUps;
    public int vidas;

    public Text contTiempo;
    public Text contScore;
    public Text contPowerUps;
    public Text contVidas;

    private NaveComportamientos naveComportamientos;

    public static Control controlInstance;

    // Start is called before the first frame update
    void Start()
    {
        tiempo = 0;
        score = 0;
        powerUps = 0;
        naveComportamientos = GetComponent<NaveComportamientos>();
        controlInstance = this;
    }

    // Update is called once per frame
    void Update()
    {
        
        tiempo += Time.deltaTime;
        vidas = naveComportamientos.vida;
        score = naveComportamientos.puntaje;
        powerUps = naveComportamientos.powerUpLvl;
        SetCountText();



    }
    void SetCountText()
    {
        contTiempo.text = "" + tiempo.ToString("F2");
        contScore.text = "" + score.ToString("F0");
        contPowerUps.text = "" + powerUps.ToString("F0");
        contVidas.text = "" + vidas.ToString("F0");

    }
}
