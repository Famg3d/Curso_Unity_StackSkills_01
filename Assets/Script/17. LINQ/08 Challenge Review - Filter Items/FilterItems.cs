using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

[System.Serializable]

public class Item
    {
    public string name;
    public int ItemID;
    public int buff;
    }
public class FilterItems : MonoBehaviour
{
    public List<Item> items;
    void Start()
    {
    //    ----------------------------------------------------------------------------

    //    var result = items.Any(item => item.itemID);

    //    ----------------------------------------------------------------------------

    //    var result = items.Where(item => item.buff > 20);

    //    foreach (var item in result)
    //    {
    //        Debug.Log("Name: " + item.name);
    //    }

    //    ----------------------------------------------------------------------------
        var result = items.Average(item => item.buff);
        Debug.Log("Average: " + result);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
