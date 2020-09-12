using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    [SerializeField]
    item_weapon sword;
    item_weapon hammer;
    item_weapon bow;
    item_weapon arrow;

    void Start()
    {
        sword = new item_weapon("Sword", 1, "This is a Sword");
        hammer =  new item_weapon ("Hammer", 2, "This is a Hammer");
        bow = new item_weapon ("Bow", 3, "This is a Bow");
        
        arrow = CreateItem("Arrow", 4, "I can Shoot this");
    }
    private item_weapon CreateItem(string name, int id, string description)
    {
        var item = new item_weapon(name, id, description);
        return item;
    }
}

