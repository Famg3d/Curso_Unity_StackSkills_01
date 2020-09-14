using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LambdaMain : MonoBehaviour
{
    public Func<string, int> CharacterLenght;

    private void Start() 
    {
      CharacterLenght = (name) => name.Length;

      int count = CharacterLenght("Jonathan");

      Debug.Log("Count: " + count);  
    }

}