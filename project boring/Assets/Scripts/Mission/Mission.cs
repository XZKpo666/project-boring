using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mission : MonoBehaviour
{
    private All_Currency All_Currency;
    // Start is called before the first frame update
    void Start()
    {
        All_Currency = FindAnyObjectByType<All_Currency>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void up_1()
    {
        if(All_Currency.All_Currency1 >= GameManagerDate.Mission_1_money)
        {
            GameManagerDate.Mission_1_money*=2;
            GameManagerDate.All_Currency3+=100;
        }
        
    }

}
