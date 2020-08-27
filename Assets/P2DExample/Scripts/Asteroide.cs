using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Asteroide : MonoBehaviour
{
    public Rigidbody2D rg2d;

    public int hp;
    AudioSource audioSource;
    public AudioClip hitmarkerClip;
    public AudioClip popClip;

    // Start is called before the first frame update
    void Start()
    {
        rg2d = gameObject.GetComponent<Rigidbody2D>();

        audioSource = Camera.main.GetComponent<AudioSource>();
        hp = 5;
    }

    // Update is called once per frame
    void Update()
    {
        if (hp <= 0)
        {
            audioSource.PlayOneShot(popClip);
            NaveComportamientos.instance.puntaje += 100;
            Destroy(gameObject);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if ( collision.gameObject.CompareTag("Laser"))
        {
            audioSource.PlayOneShot(hitmarkerClip);
            hp--;
            Destroy(collision.gameObject);
        }
    }


}
