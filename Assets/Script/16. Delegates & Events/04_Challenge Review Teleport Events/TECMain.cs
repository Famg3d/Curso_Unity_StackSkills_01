﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TECMain : MonoBehaviour
{
    public delegate void Teleport(Vector3 pos);
    public static event Teleport onTeleport;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (onTeleport != null)
            {
                Vector3 pos = new Vector3(5, 2, 0);
                onTeleport(pos);
            }
        }
    }
}
