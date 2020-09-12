using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Funciones3 : MonoBehaviour
{
    public GameObject[] _cubitos;
    // Start is called before the first frame update
    void Start()
    {
        _cubitos = GameObject.FindGameObjectsWithTag("cubitos");
        foreach (var obj in _cubitos)
        {
            Vector3 aleatorio = new Vector3(Random.Range(0, 100), Random.Range(0, 100), Random.Range(0, 100));
            Debug.Log(aleatorio);
            ChangePosition (aleatorio, obj);
        }
    }
    public void ChangePosition (Vector3 pos, GameObject o)
    {
        o.transform.position = pos;
    }
}
