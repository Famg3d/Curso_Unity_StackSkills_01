using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DESphere : MonoBehaviour
{

    void Start()
    {
        DEMain.onClick += Fall;
    }

    void Update()
    {
        
    }

    public void Fall()
    {
        GetComponent<Rigidbody>().useGravity = true;
    }
}
