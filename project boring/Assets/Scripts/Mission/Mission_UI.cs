using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Mission_UI : MonoBehaviour
{
    public Text Mission_text_1;
    public Text Mission_text_2;
    private All_Currency All_Currency;
        
    public int Mission_num;
    // Start is called before the first frame update
    void Start()
    {
        All_Currency = FindAnyObjectByType<All_Currency>();
    }

    // Update is called once per frame
    void Update()
    {
        StartCoroutine("Mission"); 
    }
    void Mission()
    {
        if(Mission_num == 1)
        {
            Mission_text_1.text = "賺取" + GameManagerDate.Mission_1_money.ToString() + "元";
            Mission_text_2.text = All_Currency.All_Currency1.ToString() + "/" + GameManagerDate.Mission_1_money.ToString();
        }
    }
}
