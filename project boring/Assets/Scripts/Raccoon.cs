using System;
using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class Raccoon : MonoBehaviour
{
    public int Raccoon_LV;
    public int Raccoon_Iteam1_LV;
    public int Raccoon_Iteam2_LV;
    public double Currency1;
    public double Currency2;
    public double Currency1_NoIteam;
    public double Currency2_NoIteam;
    public double Currency1_Iteam;
    public double Currency2_Iteam;
    private int Start_Currency1=10;
    private int Start_Currency2=3;
    private float timer = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        StartCoroutine("LoagingDate");        

        timer += Time.deltaTime ;
        if(timer >= 1)
        {
            StartCoroutine("Raccoon_OPT");
            timer = 0;
        }
        Debug.Log("Currency1 = " +Currency1+" Currency2 = "+Currency2);
        Debug.Log("LV :" + Raccoon_LV+" LV_Itema1 :" + Raccoon_Iteam1_LV + " LV_Itema2 :" + Raccoon_Iteam2_LV);

        
    }
    void Raccoon_OPT()
    {
        Currency1_NoIteam = Math.Round(Start_Currency1* Math.Pow(1.2,Raccoon_LV),0);
        Currency2_NoIteam = Math.Round(Start_Currency2* Math.Pow(1.2,Raccoon_LV),0);
        Currency1_Iteam = Math.Round(Currency1_NoIteam*(1+0.1*Raccoon_Iteam1_LV),0);
        Currency2_Iteam = Math.Round(Currency2_NoIteam*(1+0.1*Raccoon_Iteam2_LV),0);
        Currency1 = Currency1 + Currency1_NoIteam + Currency1_Iteam;
        Currency2 = Currency2 + Currency2_NoIteam + Currency2_Iteam;        
    }
    void LoagingDate()
    {
        Raccoon_LV = GameManagerDate.Raccoon_LV;
        Raccoon_Iteam1_LV = GameManagerDate.Raccoon_Iteam1_LV;
        Raccoon_Iteam2_LV = GameManagerDate.Raccoon_Iteam2_LV;
    }

}
