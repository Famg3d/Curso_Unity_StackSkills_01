using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class lINQCONTAIN : MonoBehaviour
{
    public string[] names = {"potato", "patata", "membrillo", "calabaza"};
    void Start()
    {
        var nameFound = names.Contains("potato");
        Debug.Log("NameFound: " + nameFound);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
