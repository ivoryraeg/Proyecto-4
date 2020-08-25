using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Asteroide : MonoBehaviour
{

    public int hp;

    // Start is called before the first frame update
    void Start()
    {
        hp = 5;
    }

    // Update is called once per frame
    void Update()
    {
        if (hp <= 0)
        {
            Destroy(gameObject);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if ( collision.gameObject.CompareTag("Laser"))
        {
            hp--;
            Destroy(collision.gameObject);
        }
    }


}
