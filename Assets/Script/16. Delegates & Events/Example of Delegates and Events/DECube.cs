using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DECube : MonoBehaviour
{
    void Start()
    {
        DEMain.onClick += TurnRed;
    }

    public void TurnRed()
    {
        GetComponent<MeshRenderer>().material.color = Color.red; 
    }

    private void OnDisable()
    {
        DEMain.onClick -= TurnRed;
    }
}
