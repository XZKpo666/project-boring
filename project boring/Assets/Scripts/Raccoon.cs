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
    public Button Raccoon_item1;
    public Button Raccoon_item2;
    public Button Raccoon_item1_LV_UP;
    public Button Raccoon_item2_LV_UP;
    public Text currency1_text;
    public Text currency2_text;
    public Text NextLV_text;
    public Image iteam;
    public double currency1_num;
    public double currency2_num;    
    public int LV ;
    public int item1_LV ;
    public int item2_LV ;
    public int now_item ;
    
    private float timer = 0;
    private Currency Currency;
    private GameManager GameManager ;
    // Start is called before the first frame update
    void Start()
    {
        Currency = GetComponent<Currency>();
        if (Public_LV_UP != null )
        {
            Public_LV_UP.onClick.AddListener(LV_up);
        }
        if (Raccoon_LV_UP != null )
        {
            Raccoon_LV_UP.onClick.AddListener(LV_up);
        }
        if (Raccoon_item1 != null )
        {            
            Raccoon_item1.onClick.AddListener(Raccoom_Item1);
        }
        if (Raccoon_item2 != null )
        {
            Raccoon_item2.onClick.AddListener(Raccoom_Item2);
        }
        if (Raccoon_item1_LV_UP != null )
        {
            Raccoon_item1_LV_UP.onClick.AddListener(Item1_LV);
        }
        if (Raccoon_item2_LV_UP != null )
        {
            Raccoon_item2_LV_UP.onClick.AddListener(Item2_LV);
        }
        GameManager = FindAnyObjectByType<GameManager>();
        GameManager.LoadGameState();

        
        
        
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime ;

        if(timer >= 1)
        {
            currency1_num += Math.Round(Raccoom_OPT1(Raccoon_LV(LV))+(Raccoom_OPT1(Raccoon_LV(LV))*Raccoom_Item1_description(item1_LV)),0);            
            currency2_num += Math.Round(Raccoom_OPT2(Raccoon_LV(LV))+(Raccoom_OPT2(Raccoon_LV(LV))*Raccoom_Item2_description(item2_LV)),0);
            timer = 0;
        }
        Avator1.text = "金幣生成 + "+ Raccoom_Item1_description(item1_LV)*100 +" %";
        Avator2.text = "素材生成 + "+ Raccoom_Item2_description(item2_LV)*100 +" %";
        currency1_text.text = Math.Round(Raccoom_OPT1(Raccoon_LV(LV))+(Raccoom_OPT1(Raccoon_LV(LV))*Raccoom_Item1_description(item1_LV)),0).ToString();
        currency2_text.text = Math.Round(Raccoom_OPT2(Raccoon_LV(LV))+(Raccoom_OPT2(Raccoon_LV(LV))*Raccoom_Item2_description(item2_LV)),0).ToString();
        NextLV_text.text = Raccoom_unlock_money(LV).ToString();
        
        

    }
    void currency1_persecond()
    {
        double currency1_persecond = Math.Round(Raccoom_OPT1(Raccoon_LV(LV))+(Raccoom_OPT1(Raccoon_LV(LV))*Raccoom_Item1_description(item1_LV)),0);
    }
    void LV_up()
    {        
        if(Currency.currency1 >= Raccoom_unlock_money(LV))
        {
            currency1_num = currency1_num - Raccoom_unlock_money(LV);            
            LV+=1;    
        }        
    }
    public int Raccoom_unlock_money(int LV)
    {    
        int []raccoom_unlock_money = new int[] {0,15,21,29,41,57,80,112,158,223,309,433,607};
        return raccoom_unlock_money[LV];
    }
    public int Raccoon_LV(int LV)
    {
        return LV;             
    }
    public int Raccoom_unlock_material(int LV)
    {    
        int []raccoom_unlock_material = new int[] {0,15,21,29,41,57,80,112,158,223,309,433,607};
        return raccoom_unlock_material[LV];
    }
    void Item1_LV()
    {
        if(now_item == 1)
        {
            if(Currency.currency2 >= Raccoom_unlock_material(item1_LV))
            {
            currency2_num = currency2_num - Raccoom_unlock_material(item1_LV);            
            item1_LV+=1;
            Raccoom_Item1();    
            }
        }        
    }
    void Item2_LV()
    {
        if(now_item ==2)
        {
            if(Currency.currency2 >= Raccoom_unlock_material(item2_LV))
            {
            currency2_num = currency2_num - Raccoom_unlock_material(item2_LV);            
            item2_LV+=1;
            Raccoom_Item2();    
            }
        }        
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
    public float Raccoom_Item1_description(int LV)
    {
        float []raccoom_item1 = new float[] {0,1,1.1f,1.2f,1.3f,1.4f,1.5f,1.6f,1.7f,1.8f,1.9f,2,6,5};
        return raccoom_item1[LV];
    }
    public float Raccoom_Item2_description(int LV)
    {
        float []raccoom_item2 = new float[] {0,1,1.1f,1.2f,1.3f,1.4f,1.5f,1.6f,1.7f,1.8f,1.9f,2,6,5};
        return raccoom_item2[LV];
    }
    public float Raccoom_Item1_description_num(int LV)
    {
        float []raccoom_item1 = new float[] {0,15,21,29,41,57,80,112,158,223,309,433,607};
        return raccoom_item1[LV];
    }
    public float Raccoom_Item2_description_num(int LV)
    {
        float []raccoom_item2 = new float[] {0,15,21,29,41,57,80,112,158,223,309,433,607};
        return raccoom_item2[LV];
    }

    public Text Raccoon_item1_LV;
    public Text Raccoon_item1_name;
    public Text Raccoon_item1_description;
    public Text Raccoon_item1_description_num;
    public Text Avator1;
    public Sprite Iteam1;

    void Raccoom_Item1()
    {
        now_item = 1;
        iteam.sprite = Iteam1;
        Raccoon_item1_LV.text = "LV " + item1_LV.ToString();
        Raccoon_item1_name.text = "相機";
        Raccoon_item1_description.text = "金幣生成 X "+ Raccoom_Item1_description(item1_LV)*100 +" %";
        Raccoon_item1_description_num.text = "素材 X "+ Raccoom_Item1_description_num(item1_LV);
    }
    public Text Raccoon_item2_LV;
    public Text Raccoon_item2_name;
    public Text Raccoon_item2_description;
    public Text Raccoon_item2_description_num;
    public Text Avator2;
    public Sprite Iteam2;
    void Raccoom_Item2()
    {
        now_item = 2;
        iteam.sprite = Iteam2;
        Raccoon_item2_LV.text = "LV " + item2_LV.ToString();
        Raccoon_item2_name.text = "背包";
        Raccoon_item2_description.text = "素材生成 X "+ Raccoom_Item2_description(item2_LV)*100 +" %";
        Raccoon_item1_description_num.text = "素材 X "+ Raccoom_Item1_description_num(item2_LV);
    }



}
