using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundMovimiento : MonoBehaviour
{
    public GameObject follow;
    Material material;
    Vector2 offset;

    public float velocidadX, velocidadY;

    private void Awake()
    {
        material = GetComponent<Renderer>().material;
    }

    // Start is called before the first frame update
    void Start()
    {
        offset = new Vector2(velocidadX, velocidadY);
    }

    // Update is called once per frame
    void Update()
    {

        material.mainTextureOffset += offset * Time.deltaTime;
        this.transform.position = new Vector3(follow.transform.position.x, follow.transform.position.y, follow.transform.position.y);

    }
}
