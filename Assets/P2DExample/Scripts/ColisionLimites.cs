using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColisionLimites : MonoBehaviour
{
    public GameObject referenceObj;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x < referenceObj.transform.position.x - 15.15f)
        {
            gameObject.GetComponent<RespawnAndShield>().Respawn();
            gameObject.GetComponent<NaveControles>().vida--;
        }
        if (transform.position.x > referenceObj.transform.position.x + 14.15f)
        {
            transform.position = new Vector3(referenceObj.transform.position.x + 14.15f, transform.position.y, transform.position.z);
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
        if (collision.gameObject.CompareTag("AgujeroNegro"))
        {
            gameObject.GetComponent<RespawnAndShield>().Respawn();
            gameObject.GetComponent<NaveControles>().vida--;
        }
    }
}
