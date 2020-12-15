using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunDamage : MonoBehaviour
{
    
    AudioSource gunsound;
    RaycastHit hit;
    Gunfire gFire;

    public float damageEnemy = 10f;

    //[SerializedField]
    public Transform shootPoint;

    //[SerializedField]
    public float rateOfFire;
    float nextFire = 0;

    //[SerializedField]
    public float weaponRange; 

    

    void Update()
    {
        if (!MenuPausa.isPaused)
        {
            if(Input.GetButton("Fire1"))
            {
                Shoot();
            }
        }
        

    }

    void Shoot()
    {
        if (!MenuPausa.isPaused)
        {
            if (Time.time > nextFire)
                    {
                        nextFire = Time.time + rateOfFire;
            
                        ShootingSound();
                        ShootingAnimation();



                if (Physics.Raycast(shootPoint.position, shootPoint.forward, out hit, weaponRange))
                        {
                            if(hit.transform.tag == "Enemy")
                            {
                                Debug.Log("Hit enemy");
                                EnemyHealth enemyHealthScript = hit.transform.GetComponent<EnemyHealth>();
                                enemyHealthScript.DeductHealth(damageEnemy);
                            }
                            else
                            {
                                Debug.Log("Hit anything");
                            }
                        }

                    }
        }
            
    }

    void ShootingAnimation()
    {
        gFire = GameObject.FindGameObjectWithTag("Gun").GetComponent<Gunfire>();
        gFire.Shooting();
    }

    void ShootingSound()
    {
        gunsound = GetComponent<AudioSource>();
        gunsound.Play();
    }

}
