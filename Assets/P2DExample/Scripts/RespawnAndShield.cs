using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RespawnAndShield : MonoBehaviour
{
    public Vector3 respawnPos;
    public Transform referenceObj;
    public GameObject shieldObjectPrefab;
    public GameObject shieldObject;

    private Collider2D collider;


    public bool invulnerable;
    private bool shield;

    private double invulnerableTimer;
    public double timer;

    // Start is called before the first frame update
    void Start()
    {
        invulnerable = false;
        collider = this.GetComponent<Collider2D>();
        invulnerableTimer = timer;
    }

    // Update is called once per frame
    void Update()
    {
        if (shieldObject != null)
        {
            shieldObject.transform.position = transform.position;
        }

        if (invulnerable && invulnerableTimer <= 0)
        {
            invulnerable = false;
            shield = false;
            collider.isTrigger = false;
            invulnerableTimer = timer;
            Destroy(shieldObject);
        }
        else
        {
            invulnerableTimer -= Time.deltaTime;
        }
    }
    public void Respawn()
    {
        NaveComportamientos.instance.powerUpLvl = 1;
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
            collider.isTrigger = true;
            shieldObject = Instantiate(shieldObjectPrefab, transform.position, shieldObjectPrefab.transform.rotation);
        }
    }
}
