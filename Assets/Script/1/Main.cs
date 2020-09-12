using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Main : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("Se aoreto el boton Espacio");
        }

        if (Input.GetKey(KeyCode.E))
        {
            Debug.Log("Se aoreto el boton E ");
        }
        if (Input.GetKeyUp(KeyCode.F))
        {
            Debug.Log("F");
        }

    }
}
