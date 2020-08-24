using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public Transform asteroide;
    public float timeSpawnAsteroide;
    public Transform spawner;

    // Start is called before the first frame update
    void Start()
    {
        timeSpawnAsteroide = 0;
        
    }

    // Update is called once per frame
    void Update()
    {
        timeSpawnAsteroide += Time.deltaTime;
        if(timeSpawnAsteroide > 2)
        {
            Instantiate(asteroide, spawner.position + new Vector3 (0, Random.Range(-8f,8f)) , asteroide.rotation);
            timeSpawnAsteroide = 0;
        }
    }
}
