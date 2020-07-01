using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playermovement : MonoBehaviour
{
    public Rigidbody rb;
    public KeyCode right;
    public KeyCode left;
    public float forwardForce=500f;
    public float sidewaysForce=500f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        rb.AddForce(0,0,forwardForce*Time.deltaTime);

        if(Input.GetKey(left))
        {
             rb.AddForce(sidewaysForce*Time.deltaTime,0,0,ForceMode.VelocityChange);
        }

        if(Input.GetKey(right))
        {
             rb.AddForce(-sidewaysForce*Time.deltaTime,0,0,ForceMode.VelocityChange);
        }
        
    }
}
