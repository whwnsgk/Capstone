﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 

public class GameDirector : MonoBehaviour
{
     GameObject hpGauge;

    void Start()
    {
        this.hpGauge = GameObject.Find("hp_gauge");
    }

    public void DecreaseHp()
    {
        this.hpGauge.GetComponent<Image>().fillAmount -= 0.2f;
    }
}