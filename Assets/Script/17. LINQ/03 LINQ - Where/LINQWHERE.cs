using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class LINQWHERE : MonoBehaviour
{
    public string[] names = {"potato", "patata", "potato", "membrillo", "calabaza", "calabaza"};
    void Start()
    {
        var result = names.Where(n => n.Length > 7);

        foreach (var name in result)
        {
            Debug.Log("Name: " + name);   
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
