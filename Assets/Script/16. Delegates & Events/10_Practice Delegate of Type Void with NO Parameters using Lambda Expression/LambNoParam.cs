using System;
using UnityEngine;

public class LambNoParam : MonoBehaviour
{
    public Action onGetName;
    private void Start() 
    {
        onGetName = () =>
        {
            Debug.Log("Name: " + gameObject.name);
            Debug.Log("Its a nice day out!");
        };
         onGetName(); 
    }
   
}
