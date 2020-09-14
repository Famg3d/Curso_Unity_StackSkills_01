// using System;
// using UnityEngine;

// public class SimCallbackSystem : MonoBehaviour
// {
//     private void Start() 
//     {
//         StartCoroutine(MyRoutine(() =>
//         {
//             Debug.Log("The Routine has finished");
//             Debug.Log("Wow this is cool!");
//         }));
//     }
    
//     public IEnumerator MyRoutine(Action onComplete = null)
//     {
//         yield return new WaitForSeconds(5.0f);

//         if (onComplete != null)
//             onComplete();   
//     }
// }
