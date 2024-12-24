using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Fish_bouy : MonoBehaviour
{
    public Slider Fish_buoy;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Fish_buoy.value = Fish_date.Fish_buoy;
    }
}
