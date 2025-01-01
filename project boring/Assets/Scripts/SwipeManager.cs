using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SwipeManager : MonoBehaviour
{
    public Button Raccoon_island;
    public Button Duck_island;
    public Button Ice_island;
    void Start()
    {
        // 綁定按鈕點擊事件
        Raccoon_island.onClick.AddListener(Raccoon_Island);
        Duck_island.onClick.AddListener(Duck_Island);
        Ice_island.onClick.AddListener(Ice_Island);
    }
    void Raccoon_Island()
    {
        RectTransform Raccoon_island_Transform = Raccoon_island.GetComponent<RectTransform>();
        RectTransform Duck_island_Transform = Duck_island.GetComponent<RectTransform>();
        RectTransform Ice_island_Transform = Ice_island.GetComponent<RectTransform>();

        Raccoon_island_Transform.anchoredPosition = Vector2.zero;
        Raccoon_island_Transform.sizeDelta = new Vector2(500,500);

        Duck_island_Transform.anchoredPosition = new Vector2(180,-260);
        Duck_island_Transform.sizeDelta = new Vector2(130,130);

        Ice_island_Transform.anchoredPosition = new Vector2(220,500);
        Ice_island_Transform.sizeDelta = Vector2.zero;
    }
    void Duck_Island()
    {
        RectTransform Raccoon_island_Transform = Raccoon_island.GetComponent<RectTransform>();
        RectTransform Duck_island_Transform = Duck_island.GetComponent<RectTransform>();
        RectTransform Ice_island_Transform = Ice_island.GetComponent<RectTransform>();

        Raccoon_island_Transform.anchoredPosition = new Vector2(-180,260);
        Raccoon_island_Transform.sizeDelta = new Vector2(130,130);

        Duck_island_Transform.anchoredPosition = Vector2.zero;
        Duck_island_Transform.sizeDelta = new Vector2(500,500);

        Ice_island_Transform.anchoredPosition = new Vector2(180,-260);
        Ice_island_Transform.sizeDelta = new Vector2(130,130);
    }
    void Ice_Island()
    {
        RectTransform Raccoon_island_Transform = Raccoon_island.GetComponent<RectTransform>();
        RectTransform Duck_island_Transform = Duck_island.GetComponent<RectTransform>();
        RectTransform Ice_island_Transform = Ice_island.GetComponent<RectTransform>();

        Raccoon_island_Transform.anchoredPosition = Vector2.zero;
        Raccoon_island_Transform.sizeDelta = Vector2.zero;

        Duck_island_Transform.anchoredPosition = new Vector2(-180,260);
        Duck_island_Transform.sizeDelta = new Vector2(130,130);

        Ice_island_Transform.anchoredPosition = Vector2.zero;
        Ice_island_Transform.sizeDelta = new Vector2(500,500);
    }
}

