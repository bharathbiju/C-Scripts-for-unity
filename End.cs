using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class End : MonoBehaviour
{
    public gamemanager gamemanager;
    

    void OnTriggerEnter()
    {
        gamemanager.completedlevel();
    } 
}
