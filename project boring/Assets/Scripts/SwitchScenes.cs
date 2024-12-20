using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SwitchScenes : MonoBehaviour
{
    
    private GameManager GameManager ;
    public void SwitchFishing()
    {
        SceneController.Instance.LoadScene("Fishing");
        GameManager = FindAnyObjectByType<GameManager>();
        GameManager.SaveGameState();                   
    }

    public void SwitchMain()
    {        
        SceneController.Instance.LoadScene("Main");
        GameManager = FindAnyObjectByType<GameManager>();
        GameManager.LoadGameState();
    }
}
