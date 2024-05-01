using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Diamond : MonoBehaviour
{
    public GameObject score;
    public GameObject player;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        player.GetComponent<PlayerController>().score++;
        score.GetComponent<TextMeshProUGUI>().text = "Score: "+player.GetComponent<PlayerController>().score;
        Destroy(gameObject);

    }
}
