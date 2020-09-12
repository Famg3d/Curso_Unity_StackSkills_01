using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChaPlayer04 : MonoBehaviour
{
      void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("entre");
            ChaRanColHelper.ColorChangeH(this.gameObject);
        }
    }
}
