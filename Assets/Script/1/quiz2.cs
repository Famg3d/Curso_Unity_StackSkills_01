using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class quiz2 : MonoBehaviour
{
    public int quiz;
    public int A = 90;
    public int B = 80;
    public int C = 70;
    // Start is called before the first frame update
    void Start()
    {
    
    }

    // Update is called once per frame
    void Update()
    {
        if (quiz >= A)
        {
            Debug.Log("A");
        }
        else if (quiz <= A && quiz >= B)
        {
            Debug.Log("B");
        }
        else if (quiz <= B && quiz >= C)
        {
            Debug.Log("C");
        }
        else
        {
            Debug.Log("E");
        }
    }
}
