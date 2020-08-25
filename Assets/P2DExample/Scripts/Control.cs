using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Control : MonoBehaviour
{
    public double tiempo;
    public int score;
    public int powerUps;
    public int vidas;

    public Text contTiempo;
    public Text contScore;
    public Text contPowerUps;
    public Text contVidas;

    private NaveControles naveControles;

    // Start is called before the first frame update
    void Start()
    {
        tiempo = 0;
        score = 0;
        powerUps = 0;
        naveControles = GetComponent<NaveControles>();
    }

    // Update is called once per frame
    void Update()
    {
        tiempo += Time.deltaTime;
        vidas = naveControles.vida;

        SetCountText();
    }
    void SetCountText()
    {
        contTiempo.text = "" + tiempo.ToString("F2");
        contScore.text = "" + score.ToString();
        contPowerUps.text = "" + powerUps.ToString();
        contVidas.text = "" + vidas.ToString();
    }
}
