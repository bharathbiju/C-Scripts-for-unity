using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collision : MonoBehaviour
{
    public playermovement move;

     void OnCollisionEnter(Collision other) {
        if(other.collider.tag=="box")
        {
            move.enabled=false;
            FindObjectOfType<gamemanager>().end();
        
        }
    }
}
