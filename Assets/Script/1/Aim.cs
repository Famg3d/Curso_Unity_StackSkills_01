using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;

public class Aim : MonoBehaviour
{
    [SerializeField]
    private Transform _sphere;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        UnityEngine.Vector3 directionToFace = _sphere.position - transform.position;
        Debug.DrawRay(transform.position, directionToFace, Color.green);
        transform.rotation = UnityEngine.Quaternion.LookRotation(directionToFace);

        UnityEngine.Quaternion targetRotation = UnityEngine.Quaternion.LookRotation(directionToFace);
        transform.rotation = UnityEngine.Quaternion.Slerp(transform.rotation, targetRotation, Time.deltaTime);
    }

}
