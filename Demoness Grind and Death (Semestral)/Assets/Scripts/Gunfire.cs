using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gunfire : MonoBehaviour
{
    Animator m_animator;
    


    void Start()
    {
        m_animator = GetComponent<Animator>();
    }


    public void Shooting()
    {
        m_animator.SetTrigger("Shooting");
    }



}
