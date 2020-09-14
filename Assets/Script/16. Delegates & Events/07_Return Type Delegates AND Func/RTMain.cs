using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RTMain : MonoBehaviour
{
    public Func<string, int> CharacterLenght;

    private void Start() 
    {
      CharacterLenght = GetCharacters;

      int count = CharacterLenght("Jonathan");

      Debug.Log("Count: " + count);  
    }

    int GetCharacters(string name)
    {
        return name.Length;
    }
}
