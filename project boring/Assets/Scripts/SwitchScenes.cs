using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SwitchScenes : MonoBehaviour
{
    
    
    public void SwitchFishing()
    {
        SceneManager.LoadScene(1);
    }                  
    

    public void SwitchMain()
    {        
        SceneManager.LoadScene(0);
    }
}
