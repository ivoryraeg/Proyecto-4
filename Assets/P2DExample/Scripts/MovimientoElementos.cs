using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoElementos : MonoBehaviour
{

    public float Speed = 10f;
    public float RotSpeed = 100f;
    bool isColliding;
    Rigidbody2D rg2d;


    // Start is called before the first frame update
    void Start()
    {
        rg2d = gameObject.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
        rg2d.velocity = new Vector2(-transform.right.x, transform.forward.y) * Speed;
    }

    private void OnCollisionStay2D(Collision2D collision)
    {
        isColliding = true;
        Debug.Log(collision.gameObject);
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        isColliding = false;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Death"))
        {
            Destroy(gameObject);
        }

    }
}
