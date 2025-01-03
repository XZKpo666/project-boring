using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Seal_UI : MonoBehaviour
{
    private Seal Seal;
    public Text Ice_LVmoney;
    public Text Ice_LV;
    public Text Ice_Currency1;
    public Text Ice_Currency2;
    public Text Iteam_descriptionion1;
    public Text Iteam_descriptionion2;
    // Start is called before the first frame update
    void Start()
    {
        Seal = GetComponent<Seal>();
    }

    // Update is called once per frame
    void Update()
    {
        Ice_LV.text = "LV: " + GameManagerDate.Ice_LV.ToString();
        Ice_LVmoney.text = GameManagerDate.Ice_LVmoney.ToString();
        Ice_Currency1.text = (Seal.Currency1_NoIteam + Seal.Currency1_Iteam).ToString();
        Ice_Currency2.text = (Seal.Currency2_NoIteam + Seal.Currency2_Iteam).ToString();
        Iteam_descriptionion1.text = "金幣加成 +" + (1+0.1*GameManagerDate.Ice_Iteam1_LV)*100 + "%";
        Iteam_descriptionion2.text = "素材加成 +" + (1+0.1*GameManagerDate.Ice_Iteam2_LV)*100 + "%";
    }
}
