using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class GameManager : MonoBehaviour
{
    // 靜態實例，確保全局唯一
    public static GameManager Instance { get; private set; }
    // 您希望持久化的數據
    
    private Raccoon Raccoon;
    private SwitchScenes SwitchScenes;
    public int Raccoon_LV;
    public int Raccoom_Item1_LV;
    public int Raccoom_Item2_LV;
    public double currency1_num;
    public double currency2_num;
    
        
    // Start is called before the first frame update
    void Start()
    {
        
    }
    // Update is called once per frame
    void Update()
    {
        Raccoon = FindAnyObjectByType<Raccoon>();                            
        if (Raccoon != null)
        {                        
            Debug.Log("Player LV: " + Raccoon.LV);            
        }
        else
        {
            Debug.LogError("PlayerController 的引用尚未設置！");            
        }        
    }






    // 可選：初始化或重置數據的方法
    public void InitializeGame()
    {
        // 初始化其他數據
    }
    public void SaveGameState()
    {        
        Raccoon_LV = Raccoon.LV;
        Raccoom_Item1_LV = Raccoon.item1_LV;
        Raccoom_Item2_LV = Raccoon.item2_LV;
        currency1_num = Raccoon.currency1_num;
        currency2_num = Raccoon.currency2_num;      
        // 例如，使用 PlayerPrefs、文件、數據庫等
    }
    // 可選：加載保存的狀態的方法
    public void LoadGameState()
    {
        Raccoon = FindAnyObjectByType<Raccoon>();        
        Raccoon.LV = Raccoon_LV;
        Raccoon.item1_LV = Raccoom_Item1_LV;
        Raccoon.item2_LV = Raccoom_Item2_LV;
        Raccoon.currency1_num = currency1_num;
        Raccoon.currency2_num = currency2_num;
    }
    
}
