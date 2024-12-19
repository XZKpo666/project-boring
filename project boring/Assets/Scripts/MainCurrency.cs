using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class MainCurrency : MonoBehaviour
{
    public Text currency1_text;
    public Text currency2_text;
    public Text unlock_money_text;
    private Raccoon Raccoon;
    private int Raccoon_LV ;
    // Start is called before the first frame update
    void Start()
    {
        Raccoon = GetComponent<Raccoon>();
    }

    // Update is called once per frame
    void Update()
    {
        Raccoon_LV = Raccoon.LV;

        currency1_text.text = Raccoon.Raccoom_OPT1(Raccoon_LV).ToString();
        currency2_text.text = Raccoon.Raccoom_OPT2(Raccoon_LV).ToString();
        unlock_money_text.text = Raccoon.Raccoom_unlock_money(Raccoon_LV).ToString();
    }
}
