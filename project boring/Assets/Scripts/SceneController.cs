using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{
    // 單例實例
    public static SceneController Instance { get; private set; }

    private void Awake()
    {
        // 實現單例模式
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject); // 保持在場景切換中不被銷毀
        }
        else
        {
            Destroy(gameObject); // 防止多個實例
        }
    }
    public void LoadScene(string name)
    {
        SceneManager.LoadScene(name);
    }
}
