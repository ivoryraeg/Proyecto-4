using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public Transform asteroide;
    public Transform powerUp;
    public Transform agujeroNegro;
    public Transform spawner;

    public float timeSpawnAsteroide;
    public float timeSpawnPowerUp;
    public float timeSpawnAgujero;

    // Start is called before the first frame update
    void Start()
    {
        timeSpawnAsteroide = 0;
        timeSpawnPowerUp = 0;
        timeSpawnAgujero = 0;
        
    }

    // Update is called once per frame
    void Update()
    {
        timeSpawnAsteroide += Time.deltaTime;
        timeSpawnPowerUp += Time.deltaTime;
        timeSpawnAgujero += Time.deltaTime;

        if(timeSpawnAsteroide > 2)
        {
            Instantiate (asteroide, spawner.position + new Vector3 (0, Random.Range(-6f,7f)), asteroide.rotation);
            timeSpawnAsteroide = 0;
        }
        if(timeSpawnPowerUp > 5)
        {
            Instantiate (powerUp, spawner.position + new Vector3 (0, Random.Range(-6f, 7f)), powerUp.rotation);
            timeSpawnPowerUp = 0;
        }
        if(timeSpawnAgujero > 5)
        {
            Instantiate(agujeroNegro, spawner.position + new Vector3(0, Random.Range(-6f, 7f)), agujeroNegro.rotation);
            timeSpawnAgujero = 0;
        }

    }
}
