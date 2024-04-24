using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public GameObject Player;
    private Vector3 playerPos;

    void Update()
    {
        playerPos = Player.transform.position;
        transform.position = new Vector3(playerPos.x, playerPos.y, -10);
    }
}
