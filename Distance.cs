using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Distance : MonoBehaviour
{
    public Transform player;
    public Text score;
    // Start is called before the first frame update
    

    // Update is called once per frame
    void Update()
    {
        score.text=player.position.z.ToString("0");
        
    }
}
