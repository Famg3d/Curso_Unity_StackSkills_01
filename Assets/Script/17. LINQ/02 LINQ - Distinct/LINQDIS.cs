using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class LINQDIS : MonoBehaviour
{
    public string[] names = {"potato", "patata", "potato", "membrillo", "calabaza", "calabaza"};
    void Start()
    {
        var uniqueNames = names.Distinct();

        foreach (var name in uniqueNames)
        {
            Debug.Log("Name " + name);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
