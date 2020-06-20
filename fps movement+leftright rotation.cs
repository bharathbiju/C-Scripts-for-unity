using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class MoveTagret : MonoBehaviour
{
    // Start is called before the first frame update

    public NavMeshAgent nma;

    public float turnspeed;
    public float movespeed;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector3 mouse = Input.mousePosition;
            Ray castpoint = Camera.main.ScreenPointToRay(mouse);
            RaycastHit hit;
            if(Physics.Raycast(castpoint,out hit , Mathf.Infinity))
            {
                nma.SetDestination(hit.point);
            }
         }

        transform.Translate(0, 0, movespeed * Input.GetAxis("Vertical") * Time.deltaTime);
        transform.Rotate(Vector3.up*turnspeed*Input.GetAxis("Horizontal") *Time.deltaTime);
        
    }


}
