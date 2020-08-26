using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Asteroide : MonoBehaviour
{
    public int hp;
    AudioSource audioSource;
    public AudioClip hitmarkerClip;

    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        hp = 5;
    }

    // Update is called once per frame
    void Update()
    {
        if (hp <= 0)
        {

            NaveComportamientos.instance.puntaje += 500;
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
