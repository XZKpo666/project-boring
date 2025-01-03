using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Fish_money : MonoBehaviour
{
    private Text text;
    private int money;
    private string String;
    // Start is called before the first frame update
    void Start()
    {
        text = GetComponent<Text>();
        money = Random.Range(500,1500);
        GameManagerDate.All_Currency1+=money; 
        String = money.ToString();
        text.text = String;
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
