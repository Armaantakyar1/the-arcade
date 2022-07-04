using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpPlatform : MonoBehaviour
{
    public float jumpValue;
    public Sprite JumpyJumping;
    public Sprite JumpyNormal;
    public GameObject player;
    public float Jumptimer;
    public SpriteRenderer spriteRenderer;
    //give the player a boost (add force the player)
    //check if player collides with the platform





    private void Start()
    {

    }



    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            collision.gameObject.GetComponent<Rigidbody2D>().velocity = Vector3.zero;
            collision.gameObject.GetComponent<Rigidbody2D>().AddForce(transform.up * jumpValue);
            Debug.Log("Hi!");
            player.GetComponent<SpriteRenderer>().sprite = JumpyJumping;
            

        }

    }

    private void FixedUpdate()
    {
        StartCoroutine(ChangeSprite(1));

        IEnumerator ChangeSprite(float delay)
        {
            yield return new WaitForSeconds(delay);
            //spriteRenderer.sprite = JumpyNormal;
        }
        //player.GetComponent<SpriteRenderer>().sprite = JumpyNormal;

    }

}

        /*if (Jumptimer > 0)
        {
            Jumptimer -= Time.deltaTime;
            if (Jumptimer <= 0)
            {
                resetSprite();
            }
        }*/

        

    
    

    
    
