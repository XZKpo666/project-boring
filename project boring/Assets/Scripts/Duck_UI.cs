using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Duck_UI : MonoBehaviour
{
    private Duck Duck;
    public Text Duck_LVmoney;
    public Text Duck_LV;
    public Text Duck_Currency1;
    public Text Duck_Currency2;
    public Text Iteam_descriptionion1;
    public Text Iteam_descriptionion2;
    // Start is called before the first frame update
    void Start()
    {
        Duck = GetComponent<Duck>();
    }

    // Update is called once per frame
    void Update()
    {
        Duck_LV.text = "LV: " + GameManagerDate.Duck_LV.ToString();
        Duck_LVmoney.text = GameManagerDate.Duck_LVmoney.ToString();
        Duck_Currency1.text = (Duck.Currency1_NoIteam + Duck.Currency1_Iteam).ToString();
        Duck_Currency2.text = (Duck.Currency2_NoIteam + Duck.Currency2_Iteam).ToString();
        Iteam_descriptionion1.text = "金幣加成 +" + (1+0.1*GameManagerDate.Duck_Iteam1_LV)*100 + "%";
        Iteam_descriptionion2.text = "素材加成 +" + (1+0.1*GameManagerDate.Duck_Iteam2_LV)*100 + "%";
    }
}
