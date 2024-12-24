using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Raccoon_UI : MonoBehaviour
{
    private Raccoon Raccoon;
    public Text Raccoon_LVmoney;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Raccoon_LVmoney.text = GameManagerDate.Raccoon_LVmoney.ToString();
    }
}
