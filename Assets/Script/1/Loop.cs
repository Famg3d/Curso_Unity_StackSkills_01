using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Loop : MonoBehaviour
{
    public int velocidad = 0;
    public int MaxPower;
    private void Start()
    {
        MaxPower =  Random.Range(60, 121);
        for (int velocidad = 0; velocidad < MaxPower; velocidad = velocidad + 5)
        {
            StartCoroutine(nombre());
            Debug.Log("velocidad actual " + velocidad);
        }
        Debug.Log("Frenado Emergencia " + velocidad);
    }
    private void Update()
    {

    }
    IEnumerator nombre() 
    {
        for (int e = 0; e < 30; e++)
        {
            yield return new WaitForSeconds(1.0f);
        }
    }
}
