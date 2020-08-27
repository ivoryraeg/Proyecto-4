using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NaveControles : MonoBehaviour
{
    public static NaveControles instance;

    public float jumpSpeed = 10f;
    public float Speed = 10f;
    public float RotSpeed = 100f;

    public Rigidbody2D rg2d;
    public string NextScene = "FirstScene";

    // Start is called before the first frame update
    void Start()
    {
        instance = this;
        rg2d = gameObject.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            rg2d.velocity += new Vector2(0,transform.up.y) * Time.deltaTime * Speed;
        }
        if (Input.GetKey(KeyCode.S))
        {
            rg2d.velocity += new Vector2(0, -transform.up.y) * Time.deltaTime * Speed;
        }
        if (Input.GetKey(KeyCode.D))
        {
            rg2d.velocity += new Vector2(transform.right.x, 0) * Time.deltaTime * Speed;
        }
        if (Input.GetKey(KeyCode.A))
        {
            rg2d.velocity += new Vector2(-transform.right.x, 0) * Time.deltaTime * Speed;
        }
    }

}
