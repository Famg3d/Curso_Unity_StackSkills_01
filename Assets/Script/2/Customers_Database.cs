using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Customers_Database : MonoBehaviour
{
    [SerializeField]
    public Customer_Constructor[] personas;

    void Start()
    {
        personas[0] = new Customer_Constructor("persona1", "apellido1", 10, "Genero1", "profesion1");
        personas[1] = new Customer_Constructor("persona2", "apellido2", 20, "Genero2", "profesion2");
        personas[2] = new Customer_Constructor("persona3", "apellido3", 30, "Genero3", "profesion3");

    }

}
