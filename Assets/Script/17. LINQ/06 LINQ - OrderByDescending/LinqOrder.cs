using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
// -------------ES UTIL PARA ORDERNAR INVENTARIO---------------------------------
public class LinqOrder : MonoBehaviour
{
    public int[] quizGrades = {44, 55, 32,  77, 95, 99, 88};
    void Start()
    // -------------ES UTIL PARA ORDERNAR INVENTARIO---------------------------------
    {
        var passingGrades = quizGrades.Where(qg => qg > 69).OrderByDescending(g => g).Reverse();

        foreach (var grade in passingGrades)
        {
            Debug.Log("Grade: " + grade);
        }
    }
// -------------ES UTIL PARA ORDERNAR INVENTARIO---------------------------------
    // Update is called once per frame
    void Update()
    {
        
    }
}
