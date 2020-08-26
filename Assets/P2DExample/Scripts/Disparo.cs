using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Disparo : MonoBehaviour
{
    public GameObject laser;
    private GameObject laserInstance;
    private Laser laserComponent;
    public Transform spawnLaser;
    AudioSource audioSource;
    public AudioClip disparoRayoClip;

    public Vector3 spawn;

    public float fireRate = 0.3f;
    // Start is called before the first frame update
    void Start()
    {
        spawn = new Vector3(0, 0.35f, 0);
        laserComponent = GetComponent<Laser>();
        audioSource = GetComponent<AudioSource>();
    }
    // Update is called once per frame
    void Update()
    {

        fireRate -= Time.deltaTime;

        if (Input.GetKey(KeyCode.Space) && fireRate <= 0)
        {


            if (NaveComportamientos.instance.powerUpLvl > 2)
            {
                spawn = new Vector3(0, 0.35f, 0);
            }

            switch (NaveComportamientos.instance.powerUpLvl)
            {
                case 1:
                    Instantiate(laser, spawnLaser.position + spawn, spawnLaser.rotation).GetComponent<Laser>().setDir_XY(1, 0);
                    spawn *= -1;
                    break;
                case 2:
                    Instantiate(laser, spawnLaser.position + spawn, spawnLaser.rotation).GetComponent<Laser>().setDir_XY(1, 0);
                    spawn *= -1;
                    Instantiate(laser, spawnLaser.position + spawn, spawnLaser.rotation).GetComponent<Laser>().setDir_XY(1, 0);
                    spawn *= -1;
                    break;
                case 3:
                    Instantiate(laser, spawnLaser.position + spawn, spawnLaser.rotation).GetComponent<Laser>().setDir_XY(1, 0.5f);
                    spawn *= -1;

                    Instantiate(laser, spawnLaser.position, spawnLaser.rotation).GetComponent<Laser>().setDir_XY(1, 0);

                    Instantiate(laser, spawnLaser.position + spawn, spawnLaser.rotation).GetComponent<Laser>().setDir_XY(1, -0.5f);
                    spawn *= -1;
                    break;
                case 4:
                    Instantiate(laser, spawnLaser.position + spawn * 0.5f, spawnLaser.rotation).GetComponent<Laser>().setDir_XY(1, 0);
                    spawn *= -1;
                    Instantiate(laser, spawnLaser.position + spawn * 0.5f, spawnLaser.rotation).GetComponent<Laser>().setDir_XY(1, 0);
                    spawn *= -1;

                    Instantiate(laser, spawnLaser.position + spawn, spawnLaser.rotation).GetComponent<Laser>().setDir_XY(1, 0.5f);
                    spawn *= -1;
                    Instantiate(laser, spawnLaser.position + spawn, spawnLaser.rotation).GetComponent<Laser>().setDir_XY(1, -0.5f);
                    spawn *= -1;

                    break;
            }

            if (NaveComportamientos.instance.powerUpLvl == 5)
            {
                spawn = new Vector3(0, 0.35f, 0);

                Instantiate(laser, spawnLaser.position + spawn * 0.5f, spawnLaser.rotation).GetComponent<Laser>().setDir_XY(1, 0);
                spawn *= -1;
                Instantiate(laser, spawnLaser.position + spawn * 0.5f, spawnLaser.rotation).GetComponent<Laser>().setDir_XY(1, 0);
                spawn *= -1;

                Instantiate(laser, spawnLaser.position + spawn, spawnLaser.rotation).GetComponent<Laser>().setDir_XY(1, 0.5f);
                spawn *= -1;
                Instantiate(laser, spawnLaser.position + spawn, spawnLaser.rotation).GetComponent<Laser>().setDir_XY(1, -0.5f);
                spawn *= -1;

                fireRate = 0.05f;
            }
            else
            {
                fireRate = 0.1f;
            }

            if (Input.GetKey(KeyCode.Space))
            {
                //audioSource.PlayOneShot(disparoRayoClip);
            }

 

        }
    }
}
