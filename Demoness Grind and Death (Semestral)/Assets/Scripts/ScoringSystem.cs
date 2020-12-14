using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoringSystem : MonoBehaviour
{
    public GameObject objetoText;
    public GameObject Panel;
    public static int objetosColect;

    void Update()
    {
        objetoText.GetComponent<Text>().text = objetosColect + " / 5";
        /*if (objetosColect >= 5)
        {
            Panel.gameObject.SetActive(true);
            //Application.LoadLevel("Nivel Completado");
        } else
        {
            Panel.gameObject.SetActive(false);
        }*/
            
    }


}
