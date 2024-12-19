using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Currency : MonoBehaviour
{
    private Raccoon Raccoon;
    public Text currency1_text;
    public Text currency2_text;
    public double currency1;
    public double currency2;
    
    // Start is called before the first frame update
    void Start()
    {
        Raccoon = GetComponent<Raccoon>();
         
    }

    // Update is called once per frame
    void Update()
    {
        currency1 = Raccoon.currency1_num;
        currency2 = Raccoon.currency2_num;        
        currency1_text.text = currency1.ToString();
        currency2_text.text = currency2.ToString();
    }
    
}
