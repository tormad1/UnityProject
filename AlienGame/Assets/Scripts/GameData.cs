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

    
    public GameObject volumeSlider;
    private Slider vSlider;

    public GameObject sensitivitySlider;
    private Slider sSlider;
    void Awake()
    {
        audioSource=GetComponent<AudioSource>();
        vSlider = volumeSlider.GetComponent<Slider>();
        sSlider = volumeSlider.GetComponent<Slider>();
        volume = audioSource.volume;
        DontDestroyOnLoad(gameObject);
    }

    public void SetVolume()
    {
        volume = vSlider.value;
        audioSource.volume = volume;

    }

    public void SetSesnsitivity()
    {
        sensitivity = sSlider.value;
    }
    void Update()
    {
        
    }
}
