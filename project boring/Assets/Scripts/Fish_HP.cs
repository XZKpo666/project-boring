using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Fish_HP : MonoBehaviour
{
    public Slider Fish_Hp;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Fish_Hp.value = Fish_date.Fish_HP;
        Debug.Log(Fish_date.Fish_HP);
    }
}
