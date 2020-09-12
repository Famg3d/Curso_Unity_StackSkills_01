using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class item_weapon : MonoBehaviour
{
    public string name;
    public int id;
    public string description;

    public item_weapon()
    {

    }
    public item_weapon(string name, int id, string description)
    {
        this.name = name;
        this.id = id;
        this.description = description;
    }
}
