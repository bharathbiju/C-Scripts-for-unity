﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gun : MonoBehaviour
{
    public float damage = 10f;
    public float range = 100f;

    public Camera fpscam;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButton("Fire1"))
        {
            Shoot();
        }

        void Shoot()
        {
            RaycastHit hit;
            if(Physics.Raycast(fpscam.transform.position,fpscam.transform.forward,out hit , range))
            {
                target target = hit.transform.GetComponent<target>();
                if (target != null)
                {
                    target.TakeDamage(damage);
                }

            }
        }
        
    }
}
