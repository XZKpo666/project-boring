using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Islan_lvup : MonoBehaviour
{
    public Button Raccoon;
    public Button Duck;
    public Button Ice;
    // Start is called before the first frame update
    void Start()
    {
                
        
    }

    // Update is called once per frame
    void Update()
    {
        if(GameManagerDate.Raccoon_LV ==10)
        {
            Image Raccoon_Image = Raccoon.GetComponent<Image>();                        
            Sprite Load = Resources.Load<Sprite>("Islands/raccoon_island_LV10");
            Raccoon_Image.sprite = Load;            
        }
        if(GameManagerDate.Duck_LV ==10)
        {
            Image Duck_Image = Duck.GetComponent<Image>();                        
            Sprite Load = Resources.Load<Sprite>("Islands/duck_island_LV10");
            Duck_Image.sprite = Load;            
        }
        if(GameManagerDate.Ice_LV ==10)
        {
            Image Ice_Image = Ice.GetComponent<Image>();                        
            Sprite Load = Resources.Load<Sprite>("Islands/seal_island_LV10");
            Ice_Image.sprite = Load;            
        }
    }
}
