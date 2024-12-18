using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Currency : MonoBehaviour
{
    private Raccoon Raccoon;
    public Text currency1_text;
    public Text currency2_text;
    // Start is called before the first frame update
    void Start()
    {
        Raccoon = GetComponent<Raccoon>();
    }

    // Update is called once per frame
    void Update()
    {
                
        currency1_text.text = Raccoon.currency1_num.ToString();
        currency2_text.text = Raccoon.currency2_num.ToString();
    }
}
