﻿using System;
using UnityEngine;

public class PD : MonoBehaviour
{
    public Action<int, int> Sum;
    private void Start() 
    {
        Sum = (a, b) =>
        {
            var total = a + b;
            if (total < 100)
            {
                Debug.Log("Total is less than 100");
            }   
            Debug.Log("Total: " + total);        
         };
            Sum(5, 2);
     }
}