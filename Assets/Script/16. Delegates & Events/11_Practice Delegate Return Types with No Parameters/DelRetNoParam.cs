using System;
using UnityEngine;

public class DelRetNoParam : MonoBehaviour
{
    public Func<int> onGetName;
    private void Start() 
    {
        onGetName = () => this.gameObject.name.Length;
        int characterCount = onGetName();
        Debug.Log("Character Count " + characterCount);
    }
}
