using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class Iteam_buttom : MonoBehaviour
{
    public Button Iteam1;
    public Button Iteam2;
    public Button Iteam3;
    public Button Iteam4;
    // Start is called before the first frame update
    void Start()
    {
        // 綁定按鈕點擊事件
        Iteam1.onClick.AddListener(Iteam_1);
        Iteam2.onClick.AddListener(Iteam_2);
        Iteam3.onClick.AddListener(Iteam_3);
        Iteam4.onClick.AddListener(Iteam_4);
    }
    public void Iteam_1()
    {
        GameManagerDate.Iteam_number=0;      
    }
    public void Iteam_2()
    {
        GameManagerDate.Iteam_number=1;      
    }
    public void Iteam_3()
    {
        GameManagerDate.Iteam_number=2;      
    }
    public void Iteam_4()
    {
        GameManagerDate.Iteam_number=3;      
    }
}
