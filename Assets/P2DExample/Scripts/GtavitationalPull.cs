using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GtavitationalPull : MonoBehaviour
{
    private NaveControles naveControles;
    private SpriteRenderer sprRend;
    private float opacity; 

    private float gravityForce;
    // Start is called before the first frame update
    void Start()
    {
        naveControles = GetComponent<NaveControles>();
        sprRend = GetComponent<SpriteRenderer>();
        opacity = 0f;

        gravityForce = 20;
    }

    // Update is called once per frame
    void Update()
    {
        sprRend.color = new Color(sprRend.color.r, sprRend.color.g, sprRend.color.b, opacity);

        if (opacity < 0.5f)
        {
            opacity += 0.005f;
        }
    }
    private void OnTriggerStay2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player") && opacity >= 0.5f)
        {
            if (other.transform.position.x < transform.position.x)
            {
                NaveControles.instance.rg2d.velocity += new Vector2(transform.right.x, 0) * Time.deltaTime * gravityForce;
            }
            else if (other.transform.position.x > transform.position.x)
            {
                NaveControles.instance.rg2d.velocity += new Vector2(-transform.right.x, 0) * Time.deltaTime * gravityForce;
            }

            if (other.transform.position.y < transform.position.y)
            {
                NaveControles.instance.rg2d.velocity += new Vector2(0, transform.up.y) * Time.deltaTime * gravityForce;
            }
            else if (other.transform.position.y > transform.position.y)
            {
                NaveControles.instance.rg2d.velocity += new Vector2(0, -transform.up.y) * Time.deltaTime * gravityForce;
            }
        }

        if (other.gameObject.CompareTag("Asteroide") && opacity >= 0.5f)
        {
            Asteroide asteroide = other.gameObject.GetComponent<Asteroide>();

            if (other.transform.position.x < transform.position.x)
            {
                asteroide.rg2d.velocity += new Vector2(transform.right.x, 0) * Time.deltaTime * gravityForce / 5;
            }
            else if (other.transform.position.x > transform.position.x)
            {
                asteroide.rg2d.velocity += new Vector2(-transform.right.x, 0) * Time.deltaTime * gravityForce / 5;
            }

            if (other.transform.position.y < transform.position.y)
            {
                asteroide.rg2d.velocity += new Vector2(0, transform.up.y) * Time.deltaTime * gravityForce / 5;
            }
            else if (other.transform.position.y > transform.position.y)
            {
                asteroide.rg2d.velocity += new Vector2(0, -transform.up.y) * Time.deltaTime * gravityForce / 5;
            }
        }

        if (other.gameObject.CompareTag("Laser") && opacity >= 0.5f)
        {
            Laser laser = other.gameObject.GetComponent<Laser>();

            if (other.transform.position.x < transform.position.x)
            {
                laser.rg2d.velocity += new Vector2(transform.right.x, 0) * Time.deltaTime * gravityForce*5;
            }
            else if (other.transform.position.x > transform.position.x)
            {
                laser.rg2d.velocity += new Vector2(-transform.right.x, 0) * Time.deltaTime * gravityForce*5;
            }

            if (other.transform.position.y < transform.position.y)
            {
                laser.rg2d.velocity += new Vector2(0, transform.up.y) * Time.deltaTime * gravityForce*5;
            }
            else if (other.transform.position.y > transform.position.y)
            {
                laser.rg2d.velocity += new Vector2(0, -transform.up.y) * Time.deltaTime * gravityForce*5;
            }
        }
    }
}
