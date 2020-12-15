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


    //AudioSource gunsound;

    // Start is called before the first frame update
    /*void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            gunsound = GetComponent<AudioSource>();
            gunsound.Play();
            //GetComponent<Animation>().Play("GunAnimation");
        }
    }*/



}
