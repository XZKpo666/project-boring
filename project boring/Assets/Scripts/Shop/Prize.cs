using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
public class Prize : MonoBehaviour
{
    public PrizeInfo _prizeInfo;
    [SerializeField] public Image _img;
    [SerializeField] public Text _name;
    void Start()
    {

    }

    void Update()
    {
        if (_prizeInfo != null)
        {
            _img.sprite = _prizeInfo._image;
            _name.text = _prizeInfo._name;
        }
    }
}
