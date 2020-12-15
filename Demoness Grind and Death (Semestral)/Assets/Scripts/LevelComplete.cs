using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelComplete : MonoBehaviour
{
    public GameObject nivelComplet;

    void Start()
    {
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }

    public void LoadScene()
    {
        SceneManager.LoadScene("Main Scene");
    }

    public void ReloadMenu()
    {
        SceneManager.LoadScene("Menu");
    }
}
