using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices.ComTypes;
using UnityEngine;

public class quiz5 : MonoBehaviour
{
    public int points;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            points = 50;
        }
        else if (Input.GetKeyDown(KeyCode.W))
        {
            points = 100;
        }
        if (Input.GetKeyDown(KeyCode.E))
        {
            points = 0;
        }
        switch (points)
        { 
            case 50:
                Debug.Log("50pts");
                break;
            case 100:
                Debug.Log("100pts");
                break;
            default:
                Debug.Log("invalido");
                break;
        }
    }
}
