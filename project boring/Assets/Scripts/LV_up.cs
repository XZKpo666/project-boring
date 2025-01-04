using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LV_up : MonoBehaviour
{
    void Start()
    {
        All_Currency = FindAnyObjectByType<All_Currency>();
    }
    private All_Currency All_Currency;   
    public void LV_Up_Raccoon()
    {
        if(All_Currency.All_Currency1 > GameManagerDate.Raccoon_LVmoney)
        {
            GameManagerDate.All_Currency1 -= GameManagerDate.Raccoon_LVmoney;
            GameManagerDate.Raccoon_LV+=1;
            GameManagerDate.Raccoon_LVmoney = Math.Round(GameManagerDate.Raccoon_LVmoney*1.4,0);
        }                
    }
    public void LV_Up_Duck()
    {
        if(All_Currency.All_Currency1 > GameManagerDate.Duck_LVmoney)
            {
                GameManagerDate.All_Currency1 -= GameManagerDate.Duck_LVmoney;
                GameManagerDate.Duck_LV+=1;
                GameManagerDate.Duck_LVmoney = Math.Round(GameManagerDate.Duck_LVmoney*1.5,0);
            }       
    }
    public void LV_Up_Seal()
    {
        if(All_Currency.All_Currency1 > GameManagerDate.Ice_LVmoney)
            {
                GameManagerDate.All_Currency1 -= GameManagerDate.Ice_LVmoney;
                GameManagerDate.Ice_LV+=1;
                GameManagerDate.Ice_LVmoney = Math.Round(GameManagerDate.Ice_LVmoney*1.6,0);
            }       
    }
    public void IteamLV_Up()
    {      
        if(GameManagerDate.Iteam_number==0)
        {
            if(All_Currency.All_Currency2 > GameManagerDate.Raccoon_Iteam1_LVmoney)
            {
                GameManagerDate.All_Currency2 -= GameManagerDate.Raccoon_Iteam1_LVmoney;
                GameManagerDate.Raccoon_Iteam1_LV+=1;
                GameManagerDate.Raccoon_Iteam1_LVmoney = Math.Round(GameManagerDate.Raccoon_Iteam1_LVmoney*1.3,0);
            }
        }
        if(GameManagerDate.Iteam_number==1)
        {
            if(All_Currency.All_Currency2 > GameManagerDate.Raccoon_Iteam2_LVmoney)
            {
                GameManagerDate.All_Currency2 -= GameManagerDate.Raccoon_Iteam2_LVmoney;
                GameManagerDate.Raccoon_Iteam2_LV+=1;
                GameManagerDate.Raccoon_Iteam2_LVmoney = Math.Round(GameManagerDate.Raccoon_Iteam2_LVmoney*1.3,0);
            }
        }
        if(GameManagerDate.Iteam_number==2)
        {
            if(All_Currency.All_Currency2 > GameManagerDate.Duck_Iteam1_LVmoney)
            {
                GameManagerDate.All_Currency2 -= GameManagerDate.Duck_Iteam1_LVmoney;
                GameManagerDate.Duck_Iteam1_LV+=1;
                GameManagerDate.Duck_Iteam1_LVmoney = Math.Round(GameManagerDate.Duck_Iteam1_LVmoney*1.4,0);
            }
        }
        if(GameManagerDate.Iteam_number==3)
        {
            if(All_Currency.All_Currency2 > GameManagerDate.Duck_Iteam2_LVmoney)
            {
                GameManagerDate.All_Currency2 -= GameManagerDate.Duck_Iteam2_LVmoney;
                GameManagerDate.Duck_Iteam2_LV+=1;
                GameManagerDate.Duck_Iteam2_LVmoney = Math.Round(GameManagerDate.Duck_Iteam2_LVmoney*1.4,0);
            }
        }
        if(GameManagerDate.Iteam_number==4)
        {
            if(All_Currency.All_Currency2 > GameManagerDate.Ice_Iteam1_LVmoney)
            {
                GameManagerDate.All_Currency2 -= GameManagerDate.Ice_Iteam1_LVmoney;
                GameManagerDate.Ice_Iteam1_LV+=1;
                GameManagerDate.Ice_Iteam1_LVmoney = Math.Round(GameManagerDate.Ice_Iteam1_LVmoney*1.5,0);
            }
        }
        if(GameManagerDate.Iteam_number==5)
        {
            if(All_Currency.All_Currency2 > GameManagerDate.Ice_Iteam2_LVmoney)
            {
                GameManagerDate.All_Currency2 -= GameManagerDate.Ice_Iteam2_LVmoney;
                GameManagerDate.Ice_Iteam2_LV+=1;
                GameManagerDate.Ice_Iteam2_LVmoney = Math.Round(GameManagerDate.Ice_Iteam2_LVmoney*1.5,0);
            }
        }
   
    }
}
