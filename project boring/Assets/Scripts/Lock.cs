using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lock : MonoBehaviour
{
    private All_Currency All_Currency;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Lock_Duck()
    {
        All_Currency = FindAnyObjectByType<All_Currency>();
        if(All_Currency.All_Currency1>GameManagerDate.Duck_Lock_money)
        {
            GameManagerDate.All_Currency1 -= GameManagerDate.Duck_Lock_money;
            GameManagerDate.Duck_Lock = 1;
            Destroy(gameObject);
        }
    }
    public void Lock_Ice()
    {
        All_Currency = FindAnyObjectByType<All_Currency>();
        if(All_Currency.All_Currency1>GameManagerDate.Ice_Lock_money)
        {
            GameManagerDate.All_Currency1 -= GameManagerDate.Ice_Lock_money;
            Destroy(gameObject);
        }
    }
}
