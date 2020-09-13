using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PMain : MonoBehaviour
{
    void Update() 
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray rayOrigin = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hitInfo;

            if (Physics.Raycast(rayOrigin, out hitInfo))
            {
                PDamage obj = hitInfo.collider.GetComponent<PDamage>();

                if (obj != null)
                {
                    obj.Damage(500);
                }
            }
        }
    }
}
