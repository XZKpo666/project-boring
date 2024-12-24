using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Iteam : MonoBehaviour
{
    public Text Iteam_name;
    public Text Iteam_LV;
    public Text Iteam_descriptionion1;
    public Text Iteam_descriptionion2;
    public Image Image;
    public int Iteam_number;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        StartCoroutine("List");
    }    
    void List()
    {
        if(Iteam_number == 0)
        {
            Sprite Load = Resources.Load<Sprite>("UI/CharacterInterface/raccoon_item_1");
            Iteam_name.text = "相機";
            Iteam_LV.text = "LV : "+GameManagerDate.Raccoon_Iteam1_LV.ToString();
            Iteam_descriptionion1.text = "金幣生成 X" + (1+0.1*GameManagerDate.Raccoon_Iteam1_LV)*100 + "%";
            Iteam_descriptionion2.text = "素材 X" + GameManagerDate.Raccoon_Iteam1_LVmoney;
            Image.sprite = Load; 
        }
    }
    
}
