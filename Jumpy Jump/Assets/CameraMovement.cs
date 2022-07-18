using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public Transform player;

    void Update()
    {
        Vector3 position = transform.position;
        position.y = (player.position).y;
        transform.position = position;
        
    }
}
