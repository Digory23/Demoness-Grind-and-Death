using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CargarEscena : MonoBehaviour
{
    void Start()
    {
        Cursor.lockState = CursorLockMode.None; //si lo comento se queda en medio pero se ve el mouse
        Cursor.visible = true;
    }

    public void LoadScene()
    {
        SceneManager.LoadScene("Main Scene");
        
    }

    public void QuitGame()
    {
        Application.Quit();
        Debug.Log("¡Saliste del Juego!");
    }
}
