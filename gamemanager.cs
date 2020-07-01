using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class gamemanager : MonoBehaviour
{
    
    public GameObject completedlevelt;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void completedlevel()
    {
        
        completedlevelt.SetActive(true);
    }
    
    public void End(Vector3 y ,Vector3 z, GameObject x)
    {


//x.transform.position = y;
       // x.transform.eulerAngles =z;
        
        
    }
    void restart()
    {
        
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
