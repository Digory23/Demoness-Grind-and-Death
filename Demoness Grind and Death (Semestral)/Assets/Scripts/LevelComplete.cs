using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelComplete : MonoBehaviour
{

    public void LoadScene()
    {
        SceneManager.LoadScene("Main Scene");
    }

    public void ReloadMenu()
    {
        SceneManager.LoadScene("Menu");
    }
}
