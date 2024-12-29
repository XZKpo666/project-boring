using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class All_Currency : MonoBehaviour
{
    private Raccoon Raccoon;
    private Duck Duck;
    public Text Currency1;
    public Text Currency2;
    public double All_Currency1 ;
    public double All_Currency2 ;
    private float timer = 0;
    // Start is called before the first frame update
    void Start()
    {
        Raccoon = GetComponent<Raccoon>();
        Duck = GetComponent<Duck>();
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime ;
        if(timer >= 1)
        {
            StartCoroutine("Currency");
            Currency1.text = All_Currency1.ToString();
            Currency2.text = All_Currency2.ToString();
            timer = 0;
        }
        
    }
    void Currency()
    {        
        All_Currency1 = GameManagerDate.All_Currency1 + Raccoon.Currency1 + Duck.Currency1;
        All_Currency2 = GameManagerDate.All_Currency2 + Raccoon.Currency2 + Duck.Currency2;
    }
}
