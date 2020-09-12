using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Funciones : MonoBehaviour
{
    public GameObject cube;
    public int colores;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            colores =  Random.Range(0, 4);
            Changecolor(colores);
        }
    }
    public void Changecolor(int A)
    { 
            if (A==0)
            {
                Debug.Log("RED");
                cube.GetComponent<Renderer>().material.color = Color.blue;
            }                
             if (A==1)
             {
                 Debug.Log("GREEN");
                cube.GetComponent<Renderer>().material.color = Color.red;
             }
            if (A==2)
            {
                Debug.Log("BLUE");
                cube.GetComponent<Renderer>().material.color = Color.green;
            }
             if (A==3)
             {
                 Debug.Log("BLACK");
                cube.GetComponent<Renderer>().material.color = Color.black;
             }
        }
}
