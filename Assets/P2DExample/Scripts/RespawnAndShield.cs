using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RespawnAndShield : MonoBehaviour
{
    public Vector3 respawnPos;
    public Transform referenceObj;
    public GameObject shieldObjectPrefab;
    public GameObject shieldObject;


    public bool invulnerable;
    public bool shield;

    // Start is called before the first frame update
    void Start()
    {
        invulnerable = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (shieldObject != null)
        {
            shieldObject.transform.position = transform.position;
        }
    }
    public void Respawn()
    {
        invulnerable = true;
        respawnPos = new Vector3(referenceObj.transform.position.x, referenceObj.transform.position.y, transform.position.z);
        transform.position = respawnPos;
        ShieldGenerator();
    }

    private void ShieldGenerator ()
    {
        if (invulnerable && !shield)
        {
            shield = true;
            shieldObject = Instantiate(shieldObjectPrefab, transform.position, shieldObjectPrefab.transform.rotation);
        }
    }
}
