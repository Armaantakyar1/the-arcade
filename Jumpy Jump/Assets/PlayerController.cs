using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody2D rb;
    public float jumpUpForce;
    public bool jumping;
    public float speed;
    public GamestateManager manager;
    public GameObject LeftBorder;
    public GameObject RightBorder;


    
    void Start()
    {
        jumping = false;
        rb = this.GetComponent<Rigidbody2D>();
        manager = GetComponent<GamestateManager>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (jumping == false) //If the player is NOT jumping
            {
                rb.AddForce(transform.up * jumpUpForce); //Add force and make the player jump!
                Debug.Log("JUMPING!");
                jumping = true; //Disable the jump button
            }
        }



        if (Input.GetKey(KeyCode.D))
        {
            transform.position += new Vector3(1, 0,0) * Time.deltaTime *speed ;
            manager.Current();
        }
        else if (Input.GetKey(KeyCode.A))
        {
            transform.position += new Vector3(-1, 0, 0) * Time.deltaTime * speed;
            manager.Current();
        }
    }

    //if player collides with left broder, he'll teleport to the right border vice verca.
    //delay time for teleportation so it doesn't keep teleporting back and forth

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject== LeftBorder)
        {
            transform.position = new Vector3(RightBorder.transform.position.x - 1.17395f, transform.position.y, RightBorder.transform.position.z);
        }

        if (other.gameObject == RightBorder)
        {
            transform.position = new Vector3(LeftBorder.transform.position.x + 1.17395f, transform.position.y, LeftBorder.transform.position.z);
        }


    }



}
