using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerHealth : MonoBehaviour
{
    public static int playerHealth = 100;
    public GameObject vidaText; 

    public void Update()
    {
        vidaText.GetComponent<Text>().text = playerHealth + " ";

        if (playerHealth <= 0) { PlayerDead(); }
    }

    void PlayerDead()
    {
        SceneManager.LoadScene("Game Over");
        playerHealth = 100;
        ScoringSystem.objetosColect = 0;
        Debug.Log("C muere");
    }

    public void Vida()
    {
        playerHealth -= 5;
        Debug.Log("Player damage");
        Debug.Log(playerHealth);
    }
}
