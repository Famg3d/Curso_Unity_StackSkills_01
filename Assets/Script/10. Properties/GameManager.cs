using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// public class GameManager : MonoBehaviour
// {
// void Start () 
//     {
        
//     }
// void Update () 
//     {
        
//     }
// }

// ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^


// 00_Properties
// // ejemplo de gamemanager, get, set
// public class GameManager : MonoBehaviour
// {
//     private bool isGameOver;
//     public bool IsGameOver
//     {
//         get
//         {
//             return isGameOver;
//         }
//         set
//         {
//             if (value == true)
//             {
//                 Debug.Log("oh no! The game is over!");
//             }
//             isGameOver = value;
//         }
//     }
//     // Start is called before the first frame update
//     void Start()
//     {
//         isGameOver = false;
//     }

//     // Update is called once per frame
//     void Update()
//     {
//         if (Input.GetKeyDown(KeyCode.Space))
//         {
//             IsGameOver = true;
//         }
//     }
// }

// tambien se puede escbrir
// public int/float/string/bool MyProperty { get; set; }

// que es lo mismo que (para hacerlo privado, se puede hacer lo sgte { get; privateset; })

//     private bool myProperty;
//     public bool MyProperty
//     {
//         get
//         {
//             return myProperty;
//         }
//         set
//         {
//             myProperty = value;
//         }
// // ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^

// // 12. Lists
// // 02_Challenge Review You Have Been Named
// public class GameManager : MonoBehaviour
// {
//     public List<string> names = new List<string>();
// private void Start () 
//     {
//         foreach (var name in names)
//         {
//             Debug.Log(name);
//         }
//     }
// private void Update () 
//     {
//         if (Input.GetKeyDown(KeyCode.Space))
//         {
//             var nameToRemove = names [Random.Range(0, names.Count)];

//             names.Remove(nameToRemove);

//             foreach (var name in names)
//             {
//                 Debug.Log(name);
//             }
//             Debug.Log("We removed: " + nameToRemove);
//         }
//     }
// }

// ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
// // 12. Lists 
// // 04_Challenge Review Build That Object List
// // este codigo necesita 3 objectos que se necesitan colocar en el inspector para funcionar
// public class GameManager : MonoBehaviour
// {
// public GameObject[] SpawnList = new GameObject[3];
// public List<GameObject> objectsCreated = new List<GameObject>();
// public int SpawnCount { get; set;}
// public bool _initColorChange;
// void Update () 
//     {
//         if (Input.GetKeyDown(KeyCode.Space))
//         {
//             if (SpawnCount == 10)
//             {
//                 _initColorChange = true;
//                 return;
//             }
            
//             var objectToSpawn = SpawnList[Random.Range(0,SpawnList.Length)];
//             var x = Random.Range(-10, 10);
//             var y = Random.Range(-10, 10);
//             var pos = new Vector3(x, y, 0);

//             var go = Instantiate(objectToSpawn, pos, Quaternion.identity) as GameObject;

//             objectsCreated.Add(go);

//             SpawnCount++;
//         }

//         if (_initColorChange == true)
//         {
//             _initColorChange = false;
//             foreach(var obj in objectsCreated)
//             {
//                 obj.GetComponent<MeshRenderer>().material.color = Color.green;
//             }   
//             objectsCreated.Clear();
//         }
//     }
// }
// ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^