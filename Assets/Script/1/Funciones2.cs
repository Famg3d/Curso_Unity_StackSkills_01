using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Funciones2 : MonoBehaviour
{
    public GameObject cube;
    public int health = 100;
    public void damage(int DamageCharacter)
    {
        health -= DamageCharacter;
        
        if (health < 1)
        {
            health = 0;
            Debug.Log("Dead");
        }
        
        else if (health == 0)
        {
            Debug.Log("Dead");
        }
    
    }
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    private void Update()
    {
      if (Input.GetKeyDown(KeyCode.Space))
        {
            damage(5);
                   Debug.Log(health);
        } 
 
    }

}
