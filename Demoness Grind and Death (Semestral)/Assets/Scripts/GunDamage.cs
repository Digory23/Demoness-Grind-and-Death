using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunDamage : MonoBehaviour
{

    public float damageAmount = 5f;
    public float targetDistance;
    public float allowedRange = 300f;
    // Start is called before the first frame update
    

    // Update is called once per frame
    void Update()
    {
        RaycastHit shot;

        if (Input.GetButton("Fire1"))
        {
            if(Physics.Raycast(transform.position,transform.TransformDirection(Vector3.forward), out shot, Mathf.Infinity))
            {
                Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.forward) * shot.distance, Color.yellow);
            }
            else
            {
                Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.forward) * 1000, Color.blue);
            }
        }
    }
}
