using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NaveControles : MonoBehaviour
{
    public float jumpSpeed = 10f;
    public float Speed = 10f;
    public float RotSpeed = 100f;
    public float fireRate = 0.3f;
    public GameObject laser;
    public Transform spawnLaser;
    bool isColliding;
    Rigidbody2D rg2d;
    public string NextScene = "FirstScene";

    // Start is called before the first frame update
    void Start()
    {
        rg2d = gameObject.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        fireRate -= Time.deltaTime;

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
        if (Input.GetKey(KeyCode.Space) && fireRate <= 0)
        {
            Instantiate(laser, spawnLaser.position, spawnLaser.rotation);
            fireRate = 0.3f;
        }

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
            gameObject.GetComponent<ChangeScene>().LoadScene(NextScene);
        }
        Destroy(collision.gameObject);
    }
}
