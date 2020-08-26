using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColisionLimites : MonoBehaviour
{
    public GameObject referenceObj;

    private RespawnAndShield respawn;
    private NaveComportamientos naveComportamientos;

    // Start is called before the first frame update
    void Start()
    {
        respawn = GetComponent<RespawnAndShield>();
        naveComportamientos = GetComponent<NaveComportamientos>();
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x < referenceObj.transform.position.x - 13f)
        {
            respawn.Respawn();
            naveComportamientos.vida--;
        }
        if (transform.position.x > referenceObj.transform.position.x + 12f)
        {
            transform.position = new Vector3(referenceObj.transform.position.x + 12f, transform.position.y, transform.position.z);
        }
        if (transform.position.y > referenceObj.transform.position.y + 6.5f)
        {
            transform.position = new Vector3(transform.position.x, referenceObj.transform.position.y + 6.5f, transform.position.z);
        }
        if (transform.position.y < referenceObj.transform.position.y - 6.5f)
        {
            transform.position = new Vector3(transform.position.x, referenceObj.transform.position.y - 6.5f, transform.position.z);
        }
    }
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        
    }
}
