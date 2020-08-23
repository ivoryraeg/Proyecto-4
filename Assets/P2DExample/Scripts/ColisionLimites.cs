using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColisionLimites : MonoBehaviour
{
    public Vector3 respawnPos;
    public GameObject referenceObj;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x < referenceObj.transform.position.x - 14.8f)
        {
            Respawn();
        }
        if (transform.position.x > referenceObj.transform.position.x + 14.8f)
        {
            transform.position = new Vector3(referenceObj.transform.position.x + 14.9f, transform.position.y, transform.position.z);
        }
        if (transform.position.y > referenceObj.transform.position.y + 6.8f)
        {
            transform.position = new Vector3(transform.position.x, referenceObj.transform.position.y + 6.8f, transform.position.z);
        }
        if (transform.position.y < referenceObj.transform.position.y - 6.8f)
        {
            transform.position = new Vector3(transform.position.x, referenceObj.transform.position.y - 6.8f, transform.position.z);
        }
    }
    private void Respawn()
    {
        respawnPos = new Vector3(referenceObj.transform.position.x, referenceObj.transform.position.y, transform.position.z);
        transform.position = respawnPos;
    }
}
