using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class APlayer : MonoBehaviour
{
    public Action<int> OnDamageReceived; 
    public int Health {get; set; }
    private void Start()
    {
        Health = 10;
    }
    void Damage()
    {
        Health--;
        if (OnDamageReceived != null)
            OnDamageReceived(Health);
    }
}
