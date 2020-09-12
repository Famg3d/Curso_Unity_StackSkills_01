using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class quiz3 : MonoBehaviour
{
    public GameObject cube;
    // Start is called before the first frame update
    void Start()
    {
        cube.GetComponent<Renderer>().material.color = Color.red;
    }

    // Update is called once per frame
    void Update()
    {

    }
}
