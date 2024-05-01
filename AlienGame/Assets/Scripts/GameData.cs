using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GameData : MonoBehaviour
{
    public AudioSource audioSource;

    public float volume;
    public float sensitivity;

    void Awake()
    {
        audioSource=GetComponent<AudioSource>();
        volume = audioSource.volume;
        DontDestroyOnLoad(gameObject);

    }

    void Update()
    {
        SetVolume();
        SetSesnsitivity();
    }

    public void SetVolume()
    {
        audioSource.volume = volume;
    }

    public void SetSesnsitivity()
    {
    }

}
