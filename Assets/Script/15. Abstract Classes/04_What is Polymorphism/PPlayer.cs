using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PPlayer : MonoBehaviour, PDamage
{
    public int Health {get; set; }
    public void Damage (int damageAmout)
    {
        GetComponent<MeshRenderer>().material.color = Color.red;
    }
}
