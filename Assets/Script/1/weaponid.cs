using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class weaponid : MonoBehaviour
{
    public int WeaponID;
    // Start is called before the first frame update
    void Start()
    {
  
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Z))
        {
            WeaponID = 0;
        }
        else if (Input.GetKeyDown(KeyCode.X))
        {
            WeaponID = 1;
        }
        if (Input.GetKeyDown(KeyCode.C))
        {
            WeaponID = 2;
        }
        switch (WeaponID)
        {
            case 0:
                Debug.Log("gun");
                break;
            case 1:
                Debug.Log("knife");
                break;
            case 2:
                Debug.Log("machine gun");
                break;
            default:
                Debug.Log("invalido");
                break;
        }
    }
}
