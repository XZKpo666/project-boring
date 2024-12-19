using System;
using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
//using TMPro;

public class Raccoon : MonoBehaviour
{
    public Button Public_LV_UP;
    public Button Raccoon_LV_UP;

    public double currency1_num;
    public double currency2_num;
    public Text currency1_text;
    public Text currency2_text;
    private int LV = 1;
    private float timer = 0;
    // Start is called before the first frame update
    void Start()
    {
        if (Public_LV_UP != null)
        {
            Public_LV_UP.onClick.AddListener(LV_up);
        }
        if (Raccoon_LV_UP != null)
        {
            Raccoon_LV_UP.onClick.AddListener(LV_up);
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime ;
        if(timer >= 1)
        {
            currency1_num = currency1_num + Math.Round(Raccoom_OPT1(Raccoon_LV(LV))+(Raccoom_OPT1(Raccoon_LV(LV))*Raccoom_Item1(Item1_LV(0))),0);            
            currency2_num = currency2_num + Math.Round(Raccoom_OPT2(Raccoon_LV(LV))+(Raccoom_OPT2(Raccoon_LV(LV))*Raccoom_Item2(Item2_LV(0))),0);
            timer = 0;
        }
        currency1_text.text = Raccoom_OPT1(LV).ToString();
        currency2_text.text = Raccoom_OPT2(LV).ToString();      
    }
    void LV_up()
    {
        LV+=1;
    }
    public int Raccoon_LV(int LV)
    {
        return LV;             
    }
    public int Item1_LV(int LV)
    {
        return LV;             
    }
    public int Item2_LV(int LV)
    {
        return LV;             
    }
    public int Raccoom_OPT1(int LV)
    {    
        int []raccoom_OPT1 = new int[] {0,10,12,14,17,20,24,29,35,42,50,60,72};
        return raccoom_OPT1[LV];
    }
    public int Raccoom_OPT2(int LV)
    {    
        int []raccoom_OPT2 = new int[] {0,3,4,5,6,7,8,10,12,14,17,20,24};
        return raccoom_OPT2[LV];
    }
    public float Raccoom_Item1(int LV)
    {
        float []raccoom_item1 = new float[] {0,1,1.1f,1.2f,1.3f,1.4f,1.5f,1.6f,1.7f,1.8f,1.9f,2,6,5};
        return raccoom_item1[LV];
    }
    public float Raccoom_Item2(int LV)
    {
        float []raccoom_item2 = new float[] {0,1,1.1f,1.2f,1.3f,1.4f,1.5f,1.6f,1.7f,1.8f,1.9f,2,6,5};
        return raccoom_item2[LV];
    }


}
