using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AgujeroNegro : MonoBehaviour
{
    public GameObject other;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    // Update is called once per frame
    void Update()
    {
        /*
        if (Vector3.Distance(other.transform.position, transform.position) < 500)
        {
            if (other.transform.position.x < transform.position.x)
            {
                other.transform.position += new Vector3(0.1f, 0, 0);
            }
            else if (other.transform.position.x > transform.position.x)
            {
                other.transform.position -= new Vector3(0.1f, 0, 0);
            }

            if (other.transform.position.y < transform.position.y)
            {
                other.transform.position += new Vector3(0, 1f, 0);
            }
            else if (other.transform.position.y > transform.position.y)
            {
                other.transform.position -= new Vector3(0, 1f, 0);
            }
        }
        */
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("Asteroide") || collision.gameObject.CompareTag("Laser") || collision.gameObject.CompareTag("PowerUp"))
        {
            Destroy(collision.gameObject);
        }
    }
}
