using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Empleados : MonoBehaviour
{
    public static string company = "GameDevHQ";
    public string empleadoName;

    public abstract void CalculateMonthlySalary();
}
