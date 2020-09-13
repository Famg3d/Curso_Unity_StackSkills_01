using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PEnemy : MonoBehaviour, PDamage, PShoot
{
    public int Health
    {
        get;
        set;
    }

    public void Damage (int damageAmount)
    {
        Health -= damageAmount;
        GetComponent<MeshRenderer>().material.color = Color.red;
    }

    public void Shoot()
    {
        throw new System.NotImplementedException();
    }
}
