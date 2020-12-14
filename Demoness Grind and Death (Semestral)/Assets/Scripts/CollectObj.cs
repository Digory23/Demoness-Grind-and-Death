using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectObj : MonoBehaviour
{
    public AudioSource collectSound;

    void OnTriggerEnter(Collider other)
    {
        collectSound.Play();
        ScoringSystem.objetosColect += 1;
        Destroy(gameObject);
    }
}
