using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[System.Serializable]
public class Customer_Constructor
{
    public string First_Name;
    public string Last_Name;
    public int Age;
    public string Gender;
    public string Occupation;
    public Customer_Constructor()
    {

    }
    public Customer_Constructor(string First_Name, string Last_Name, int Age, string Gender, string Occupation)
    {
        this.First_Name = First_Name;
        this.Last_Name = Last_Name;
        this.Age = Age;
        this.Gender = Gender;
        this.Occupation = Occupation;
    }
}
