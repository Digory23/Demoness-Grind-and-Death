using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoringSystem : MonoBehaviour
{
    public GameObject objetoText;
    public static int objetosColect;

    void Update()
    {
        objetoText.GetComponent<Text>().text = objetosColect + " / 5";
    }


}
