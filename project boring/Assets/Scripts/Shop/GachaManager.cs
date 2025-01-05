using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GachaManager : MonoBehaviour
{
    public Prize _prize;
    public GameObject gameObject1;
    public MonoBehaviour targetScript1;
    public MonoBehaviour targetScript2;
    private bool isRuning = false;
    [SerializeField] private PrizeInfo[] _prizePool;
    [SerializeField] private Image _prizeImage;
    [SerializeField] private Text _prizeName;

    public void Pull()
    {        
        if(GameManagerDate.All_Currency3 >= 500)
        {
            if (_prizePool.Length == 0)
            {
                _prize._name.text = "抽完了";
                return;
            }
            gameObject1.SetActive(!gameObject1.activeSelf);
            GameManagerDate.All_Currency3 -=500;
            int randomIndex = Random.Range(0, _prizePool.Length);
            PrizeInfo drawnCard = _prizePool[randomIndex];

            _prize._img.sprite = drawnCard._image;
            _prize._name.text = drawnCard._name;
            RemoveCardFromPool(randomIndex);

            //gameObject1.SetActive(!gameObject1.activeSelf);
        }
        else
        {
            targetScript1.enabled = false;
        }

    }

    private void RemoveCardFromPool(int index)
    {
        PrizeInfo[] newCardPool = new PrizeInfo[_prizePool.Length - 1];
        int newIndex = 0;
        for (int i = 0; i < _prizePool.Length; i++)
        {
            if (i == index) continue;
            newCardPool[newIndex] = _prizePool[i];
            newIndex++;
        }
        _prizePool = newCardPool;
    }

}
