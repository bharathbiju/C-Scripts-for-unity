using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class splitcam : MonoBehaviour
{
    public Camera cam1, cam2;
    private bool isHorizontal;
    // Start is called before the first frame update
    void Start()
    {
        cam1.rect = new Rect(0f, .5f, 1f, .5f);
        cam2.rect = new Rect(0f, 0f, 1f, .5f);

    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.X))
        {
            isHorizontal = !isHorizontal;
            SetSplitScreen();
        }
        
    }

    public void SetSplitScreen()
    {
        if(isHorizontal)
        {
            cam1.rect = new Rect(0f, .5f, 1f, .5f);
            cam2.rect = new Rect(0f, 0f, 1f, .5f);

        }
        else
        {
            cam1.rect = new Rect(0f,0f,.5f,1f);
            cam2.rect = new Rect(.5f, 0f, .5f, 1f);
        }
    }
}
