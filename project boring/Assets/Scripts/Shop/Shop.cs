using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shop : MonoBehaviour
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
    public void Shop_Currency1()
    {
        if(GameManagerDate.All_Currency3 >= 1000)
        {
            GameManagerDate.All_Currency1 *= 86400;
            GameManagerDate.All_Currency3 -= 1000;            
        }        
    }
    public void Shop_Currency2()
    {
        if(GameManagerDate.All_Currency3 >= 1000)
        {
            GameManagerDate.All_Currency2 *= 86400;
            GameManagerDate.All_Currency3 -= 1000;            
        }        
    }
}
