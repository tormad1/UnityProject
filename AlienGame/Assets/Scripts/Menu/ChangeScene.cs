using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    public void ButtonPressed(int sceneBuildNum)
    {
        SceneManager.LoadScene(sceneBuildNum);
    }
}
