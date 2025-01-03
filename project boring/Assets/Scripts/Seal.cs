using System;
using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class Seal : MonoBehaviour
{
    public int Ice_LV;
    public int Ice_Iteam1_LV;
    public int Ice_Iteam2_LV;
    public double Currency1;
    public double Currency2;
    public double Currency1_NoIteam;
    public double Currency2_NoIteam;
    public double Currency1_Iteam;
    public double Currency2_Iteam;
    private int Start_Currency1=1000;
    private int Start_Currency2=300;
    private float timer = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(GameManagerDate.Ice_Lock == 1)
        {
            StartCoroutine("LoagingDate");
            timer += Time.deltaTime ;
            if(timer >= 1)
            {
                StartCoroutine("Ice_OPT");
                timer = 0;
            }
        }                
    }
    void Ice_OPT()
    {
        Currency1_NoIteam = Math.Round(Start_Currency1* Math.Pow(1.5,Ice_LV),0);
        Currency2_NoIteam = Math.Round(Start_Currency2* Math.Pow(1.5,Ice_LV),0);
        Currency1_Iteam = Math.Round(Currency1_NoIteam*(1+0.1*Ice_Iteam1_LV),0);
        Currency2_Iteam = Math.Round(Currency2_NoIteam*(1+0.1*Ice_Iteam2_LV),0);
        Currency1 = Currency1 + Currency1_NoIteam + Currency1_Iteam;
        Currency2 = Currency2 + Currency2_NoIteam + Currency2_Iteam;        
    }
    void LoagingDate()
    {
        Ice_LV = GameManagerDate.Ice_LV;
        Ice_Iteam1_LV = GameManagerDate.Ice_Iteam1_LV;
        Ice_Iteam2_LV = GameManagerDate.Ice_Iteam2_LV;
    }

}
