using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class colorchange : MonoBehaviour
{
    public GameObject cube;
    public int number;
    // Start is called before the first frame update
    void Start()
    {
        cube.GetComponent<Renderer>().material.color = Color.blue;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            number = 0;
        }
        if (Input.GetKeyDown(KeyCode.W))
        {
            number = 1;
        }
        if (Input.GetKeyDown(KeyCode.E))
        {
            number = 2;
        }
        if (Input.GetKeyDown(KeyCode.R))
        {
            number = 3;
        }

        switch (number)
        { 
            case 0:
                Debug.Log("RED");
                cube.GetComponent<Renderer>().material.color = Color.blue;
                break;
            case 1:
                Debug.Log("GREEN");
                cube.GetComponent<Renderer>().material.color = Color.red;
                break;
            case 2:
                Debug.Log("BLUE");
                cube.GetComponent<Renderer>().material.color = Color.green;
                break;
            case 3:
                Debug.Log("BLACK");
                cube.GetComponent<Renderer>().material.color = Color.black;
                break;
            default:
                Debug.Log("invalido");
                break;
        }
    }
}
