using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class ChaRanColHelper
{   
    public static void ColorChangeH(GameObject obj)
    {
        Debug.Log("entreHelper");
        obj.GetComponent<Renderer>().material.color = new Color(Random.Range(0f, 1f), Random.Range(0f, 1f), Random.Range(0f, 1f), 1);
    }
}
