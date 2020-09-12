using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scoretest1 : MonoBehaviour
{
    private void Start()
    {
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            staticscore.score += 10;
            Debug.Log("Current Score¨: " + staticscore.score);
        }
    }
}
