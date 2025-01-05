using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animal_Postion : MonoBehaviour
{
    private GachaManager GachaManager;
    public GameObject Animal_1;
    public Transform Animal_1_transform;
    public GameObject Animal_2;
    public Transform Animal_2_transform;
    public GameObject Animal_3;
    public Transform Animal_3_transform;
    public GameObject Animal_4;
    public Transform Animal_4_transform;
    public GameObject Animal_5;
    public Transform Animal_5_transform;
    public GameObject Animal_6;
    public Transform Animal_6_transform;
    public GameObject Animal_7;
    public Transform Animal_7_transform;
    // Start is called before the first frame update
    void Start()
    {
        GachaManager = FindAnyObjectByType<GachaManager>();
    }

    // Update is called once per frame
    public void A()
    {
        if(GachaManager.X == 0)
        {
            Instantiate(Animal_1,Animal_1_transform);
        }
        if(GachaManager.X == 1)
        {
            Instantiate(Animal_2,Animal_2_transform);
        }
        if(GachaManager.X == 2)
        {
            Instantiate(Animal_3,Animal_3_transform);
        }
        if(GachaManager.X == 3)
        {
            Instantiate(Animal_4,Animal_4_transform);
        }
        if(GachaManager.X == 4)
        {
            Instantiate(Animal_5,Animal_5_transform);
        }
        if(GachaManager.X == 5)
        {
            Instantiate(Animal_6,Animal_6_transform);
        }
        if(GachaManager.X == 6)
        {
            Instantiate(Animal_7,Animal_7_transform);
        }
    }
}
