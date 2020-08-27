using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public Transform asteroide;
    public Transform powerUp;
    public Transform agujeroNegro;
    public Transform gravitationalPull;
    public Transform spawner;

    public float timeChangeDifficulty;

    public float timeSpawnAsteroide;
    public float timeMaxSpawnAsteroide;
    public float timeSpawnPowerUp;
    public float timeSpawnAgujero;

    private Transform agujeroNegroPos;

    // Start is called before the first frame update
    void Start()
    {
        timeChangeDifficulty = 5;
        timeSpawnAsteroide = 0;
        timeMaxSpawnAsteroide = 2;
        timeSpawnPowerUp = 0;
        timeSpawnAgujero = 0;
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Control.controlInstance.tiempo > timeChangeDifficulty)
        {
            timeChangeDifficulty += timeChangeDifficulty;
            timeMaxSpawnAsteroide /= 1.5f;
        }

        timeSpawnAsteroide += Time.deltaTime;
        timeSpawnPowerUp += Time.deltaTime;
        timeSpawnAgujero += Time.deltaTime;

        if(timeSpawnAsteroide > timeMaxSpawnAsteroide)
        {
            Instantiate (asteroide, spawner.position + new Vector3 (0, Random.Range(-6f,7f), 1), asteroide.rotation);
            timeSpawnAsteroide = 0;
        }
        if(timeSpawnPowerUp > 20)
        {
            Instantiate (powerUp, spawner.position + new Vector3 (0, Random.Range(-6f, 7f), 2), powerUp.rotation);
            timeSpawnPowerUp = 0;
        }
        if(timeSpawnAgujero > 10)
        {
            agujeroNegroPos = Instantiate(agujeroNegro, spawner.position + new Vector3(0, Random.Range(-6f, 7f), 3), agujeroNegro.rotation);
            Instantiate(gravitationalPull, agujeroNegroPos.position, gravitationalPull.rotation);
            timeSpawnAgujero = 0;
        }

    }
}
