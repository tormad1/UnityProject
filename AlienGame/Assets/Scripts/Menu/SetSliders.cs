using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SetSliders : MonoBehaviour
{
    private GameData gameData;
    private Slider slider;


    private void Awake()
    {
        GameObject gManager = GameObject.Find("GameManager");
        gameData = gManager.GetComponent<GameData>();
        slider = gameObject.GetComponent<Slider>();
    }

    public void VolumeChange()
    {
        gameData.volume = slider.value;
    }
    public void SensitivityChange()
    {
        gameData.sensitivity = slider.value;
    }
}
