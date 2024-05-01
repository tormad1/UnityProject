using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JetPack : MonoBehaviour
{
    public GameObject player;
    PlayerController playerController;
    private Vector3 playerPos;

    BoxCollider2D bc;
    bool triggered;
    private void Awake()
    {
        bc = gameObject.GetComponent<BoxCollider2D>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("OIOIOIOIO");
        triggered=true;
        playerController=player.GetComponent<PlayerController>();
        playerController.hasJetPack = true;

    }


    private void Update()
    {
        if (triggered==true)
        {
            playerPos = player.transform.position;
            transform.position = new Vector3(playerPos.x, playerPos.y - 0.1f, playerPos.z);
        }
    }
}
