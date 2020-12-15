using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public float playerHealth = 100f;

    public void HealthLoss()
    {
        playerHealth -= 5;
        Debug.Log("Player damage");
        Debug.Log(playerHealth);

        if (playerHealth <= 0) { PlayerDead(); }
    }

    void PlayerDead()
    {

        Debug.Log("C muere");
    }
}
