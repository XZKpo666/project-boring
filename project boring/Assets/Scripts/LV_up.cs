using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LV_up : MonoBehaviour
{
    private All_Currency All_Currency;    
    public void LV_Up()
    {
        All_Currency = FindAnyObjectByType<All_Currency>();
        if(All_Currency.All_Currency1 > GameManagerDate.Raccoon_LVmoney)
        {
            GameManagerDate.All_Currency1 -= GameManagerDate.Raccoon_LVmoney;
            GameManagerDate.Raccoon_LV+=1;
            GameManagerDate.Raccoon_LVmoney = Math.Round(GameManagerDate.Raccoon_LVmoney*1.4,0);
        }        
    }
    public void IteamLV_Up()
    {
        All_Currency = FindAnyObjectByType<All_Currency>();
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
        
    }
}
