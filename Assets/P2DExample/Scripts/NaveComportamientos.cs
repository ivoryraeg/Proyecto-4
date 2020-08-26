﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class NaveComportamientos : MonoBehaviour
{
    private RespawnAndShield respawnAndShield;

    public static NaveComportamientos instance;

    public int vida;
    public int puntaje;
    public int powerUpLvl;
    public int powerUpTotales;
    public int nuevaVida;

    // Start is called before the first frame update
    void Start()
    {
        instance = this;
        respawnAndShield = GetComponent<RespawnAndShield>();
        vida = 5;
        puntaje = 0;
        powerUpLvl = 1;
        powerUpTotales = 0;
        nuevaVida = 25000;

    }

    // Update is called once per frame
    void Update()
    {
        if (vida == 0)
        {
            PlayerPrefs.SetInt("score", puntaje);
            PlayerPrefs.SetInt("powerUps", powerUpTotales);
            PlayerPrefs.SetFloat("tiempo", Control.controlInstance.tiempo);

            gameObject.GetComponent<ChangeScene>().LoadScene("ThirdScene");

        }

        if (puntaje >= nuevaVida )
        {
            nuevaVida += 25000;
            vida++;
        }

        

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("PowerUp"))
        {

            powerUpTotales++;

            if (powerUpLvl < 5)
            {
                powerUpLvl++;
            }
            puntaje += 5000;
            Destroy(collision.gameObject);
        }
        if (!respawnAndShield.invulnerable && collision.gameObject.CompareTag("AgujeroNegro"))
        {
            respawnAndShield.Respawn();
            vida--;
        }

    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (!respawnAndShield.invulnerable && collision.gameObject.CompareTag("Asteroide"))
        {
            vida--;
        }
    }
}