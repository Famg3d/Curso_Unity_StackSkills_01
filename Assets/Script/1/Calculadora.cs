using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Calculadora : MonoBehaviour
{
    public int bill = 40;
    public float tip = 20.0f;
    public float total;
    // Start is called before the first frame update
    void Start()
    {
        float total = bill * (tip / 100);
        Debug.Log("El dinero total es " + bill * tip / 100);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
