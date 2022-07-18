using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroyer : MonoBehaviour
{
    public Transform player;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Ground")
        {
            Destroy(collision.gameObject);
        }

        if (collision.gameObject.tag == "Position Point")
        {
            Destroy(collision.gameObject);
        }
        if (collision.gameObject.tag == "Breaking Ground")
        {
            Destroy(collision.gameObject);
        }
    }
}
    
   
   
