using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DictionaryBooks : MonoBehaviour
{
    public Dictionary<int, string> books = new Dictionary<int, string>();
    private void Start()
    {
        books.Add(0, "Logar Book");
        books.Add(1, "Imperium Book");

        Debug.Log("------------METODO FOREACH 1--------------");

        foreach(KeyValuePair<int, string> book in books)
        {
            Debug.Log("Book: " + book.Value);
        }

            Debug.Log("-----------METODO FOREACH 2---------------");

        foreach(string book in books.Values)
        {
            Debug.Log("Book: " + book);
        }
            Debug.Log("-----------METODO FOR---------------");
        for (int i = 0; i < books.Count; i++)
        {
            Debug.Log("Book: " + books[i]);
        }

            Debug.Log("-----------FORMA DIRECTA---------------");

            Debug.Log(books[1]);


    }

}
