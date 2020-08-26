using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Laser : MonoBehaviour
{
    public float velocidadLaser;
    Rigidbody2D rg2d;

    private float dir_x, dir_y;
    private void Awake()
    {
        rg2d = GetComponent<Rigidbody2D>();
    }
    // Start is called before the first frame update
    void Start()
    {
        rg2d.velocity = new Vector3(dir_x, dir_y, 0) * velocidadLaser;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void setDir_XY(float x, float y)
    {
        dir_x = x;
        dir_y = y;
    }
}
