using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class quiz4 : MonoBehaviour
{
    public float movementSpeed = 10f;

    // Start is called before the first frame update
    void Start()
    {
    
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.S))
        {
            movementSpeed += 10;
        }

        else if (Input.GetKeyUp(KeyCode.A))
        {
            movementSpeed -= 10;
        }
        if (movementSpeed >= 20)
        {
            Debug.Log("anda lento");
        }
         else if (movementSpeed <= 0)
        {
            Debug.Log("mas rapido");
        }
    }
}
