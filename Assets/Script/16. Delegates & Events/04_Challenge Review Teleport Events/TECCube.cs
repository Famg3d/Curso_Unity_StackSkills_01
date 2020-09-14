using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TECCube : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        TECMain.onTeleport += Spawn;
    }

    // Update is called once per frame
    public void Spawn (Vector3 pos)
    {
        transform.position = pos;
    }

    private void OnDisable() 
    {
        TECMain.onTeleport -= Spawn;
    }
}
