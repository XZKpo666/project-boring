using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fish_GameManager : MonoBehaviour
{
    int Fish_object;
    int Fish_HP;
    int Fish_Postion;
    int Fish_RunArea;
    public GameObject window;
    public Transform WIN;

    // Start is called before the first frame update
    void Start()
    {
        Fish_date.Fish_RunArea = Fish_RunArea;

        Fish_object = Random.Range(0,100);
        Fish_date.Fish_object = Fish_object;

        Fish_date.Fish_Postion = Fish_Postion;

        Fish_HP = Random.Range(20,54);
        Fish_date.Fish_HP = Fish_HP;

        StartCoroutine("Fishing_RunArea");
        StartCoroutine("Fish_buoy");
    }

    // Update is called once per frame
    void Update()
    {
        if(Fish_date.Fish_HP <0 || Fish_date.Fish_HP >100)
        {
            StopCoroutine("Fishing_RunArea");
            StopCoroutine("Fish_buoy");
            Instantiate(window,WIN);
            Destroy(gameObject);
            
        }
        
    }
    IEnumerator Fishing_RunArea()
    {
        while(true)
        {
            yield return new WaitForSecondsRealtime(0.3f);
            int Displacement; //魚的位置
            int count = Random.Range(0,2); //浮標在魚身上的時間
            if(count > 0)
            {
                Displacement = Random.Range(-10,11);
                if(Displacement + Fish_date.Fish_object > 100)
                {
                    Fish_date.Fish_object = Fish_date.Fish_object + Random.Range(-10,-1);
                }
                else if (Displacement + Fish_date.Fish_object < 0)
                {
                    Fish_date.Fish_object = Fish_date.Fish_object + Random.Range(1,10);
                }
                else
                {
                    Fish_date.Fish_object = Fish_date.Fish_object + Displacement;
                }                    
            }    
            else
            {
              Displacement = Random.Range(-20,20);
              if (Displacement + Fish_date.Fish_object > 100)
                {
                    Fish_date.Fish_object = Fish_date.Fish_object + Random.Range(-20, -10);
                }
                else if (Displacement + Fish_date.Fish_object < 0)
                {
                    Fish_date.Fish_object = Fish_date.Fish_object + Random.Range(10, 20);
                }

                else
                {
                    Fish_date.Fish_object = Fish_date.Fish_object + Displacement;
                }                
            }    
            if((Fish_date.Fish_object + 7 >= Fish_date.Fish_buoy) && (Fish_date.Fish_object - 7<= Fish_date.Fish_buoy))
            {
                Fish_date.Fish_HP = Fish_date.Fish_HP + 12;
            }
            else
            {
                Fish_date.Fish_HP = Fish_date.Fish_HP - 1;
            }
        }

    }
    
    public void touch()//點擊釣魚
    {
        Fish_date.Fish_buoy = Fish_date.Fish_buoy + 12;
    }
    IEnumerator Fish_buoy()
    {
        while (true)
        {
            yield return new WaitForSecondsRealtime(0.1f);
            if(Fish_date.Fish_buoy - 2 > 1)
            {
                Fish_date.Fish_buoy = Fish_date.Fish_buoy - 4;
            }
        }
    }
    IEnumerator Fish_start()
    {
        while(true)
        {
            yield return new WaitForSecondsRealtime(0.3f);

        }
    }
}
