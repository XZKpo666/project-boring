using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Raccoon_UI : MonoBehaviour
{
    private Raccoon Raccoon;
    public Text Raccoon_LVmoney;
    public Text Raccoon_LV;
    public Text Raccoon_Currency1;
    public Text Raccoon_Currency2;
    public Text Iteam_descriptionion1;
    public Text Iteam_descriptionion2;
    // Start is called before the first frame update
    void Start()
    {
        Raccoon = GetComponent<Raccoon>();
    }

    // Update is called once per frame
    void Update()
    {
        Raccoon_LV.text = "LV: " + GameManagerDate.Raccoon_LV.ToString();
        Raccoon_LVmoney.text = GameManagerDate.Raccoon_LVmoney.ToString();
        Raccoon_Currency1.text = (Raccoon.Currency1_NoIteam + Raccoon.Currency1_Iteam).ToString();
        Raccoon_Currency2.text = (Raccoon.Currency2_NoIteam + Raccoon.Currency2_Iteam).ToString();
        Iteam_descriptionion1.text = "金幣加成 +" + (1+0.1*GameManagerDate.Raccoon_Iteam1_LV)*100 + "%";
        Iteam_descriptionion2.text = "素材加成 +" + (1+0.1*GameManagerDate.Raccoon_Iteam2_LV)*100 + "%";
    }
}
