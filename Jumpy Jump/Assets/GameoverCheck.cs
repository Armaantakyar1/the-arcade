using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameoverCheck : MonoBehaviour
{
    public GamestateManager manager;
    public GameObject player;
    public float speed;

    void Update()
    {
        transform.position += Vector3.up * speed* Time.deltaTime;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag=="Player")
        {
            Debug.Log("Game Over@");
            manager.Gameover();
        }
    }
}
