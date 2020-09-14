using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EDPPlayer : MonoBehaviour
{
    public delegate void OnDeath();
    public static event OnDeath onDeath;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Death();
        }
    }

    void Death()
    {
        if (onDeath != null)
        {
            onDeath();
        }
    }
}
