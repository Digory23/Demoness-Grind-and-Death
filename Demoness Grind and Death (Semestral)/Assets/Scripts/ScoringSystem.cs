using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ScoringSystem : MonoBehaviour
{
    public GameObject objetoText;
    public static int objetosColect = 0;

    void Update()
    {
        objetoText.GetComponent<Text>().text = objetosColect + " / 5";

        if (objetosColect >= 5)
        {
            PlayerHealth.playerHealth = 100;
            SceneManager.LoadScene("Nivel Completado 1"); //codigo para pasar a otra escena
            objetosColect = 0;
        } 
            
    }

}
