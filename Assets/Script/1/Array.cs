using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Array : MonoBehaviour
{
    public string[] names = new string[] {"la", "le", "li", "lo", "lu"};
    public int[] ages = new int[] {10, 12, 14, 16, 18};
    public string[] cars = new string[] {"car1", "car2", "car3", "car4", "car5"};
    public int kids;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {   kids =  Random.Range(0, 4);
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log(names[kids] + ages [kids] + cars [kids]);
        }
    }
}
