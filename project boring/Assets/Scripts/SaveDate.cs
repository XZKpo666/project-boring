using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveDate : MonoBehaviour
{
    private All_Currency All_Currency;
    // Start is called before the first frame update
    void Start()
    {
        All_Currency = GetComponent<All_Currency>();    
    }
    public void Save()
    {
        GameManagerDate.All_Currency1 = All_Currency.All_Currency1;
        GameManagerDate.All_Currency2 = All_Currency.All_Currency2;
    }
}
