﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHome : MonoBehaviour
{
    private int health; //易承的手手有10滴血

    // Start is called before the first frame update
    void Start()
    {
        health = 10;
    }

    // Update is called once per frame
    void Update()
    {
        if(health == 0){
            // 易承的手手爆炸
            
        }
    }
}