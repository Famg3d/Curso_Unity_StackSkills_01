using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerC
{
    public string name;
    public int id;

    public PlayerC(int id)
    {
        this.id = id;
    }
}
public class DictionaryPlayerConnections : MonoBehaviour
{
    public Dictionary<int, PlayerC> playerDictionary = new Dictionary<int, PlayerC>();
    PlayerC p4;
    private void Start()
    {
        PlayerC p1 = new PlayerC(1);
        p1.name = "jimmy";
        PlayerC p2 = new PlayerC(200);
        p2.name = "kyle";
        PlayerC p3 = new PlayerC(9);
        p3.name = "yin";
        p4 = new PlayerC(500);
        p4.name = "juan";

        playerDictionary.Add(p1.id, p1);
        playerDictionary.Add(p2.id, p2);
        playerDictionary.Add(p3.id, p3);
        playerDictionary.Add(p4.id, p4);
    }

    // Update is called once per frame
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            var player = playerDictionary[200];
            Debug.Log("Player name: " + player.name);

            var player1 = playerDictionary[p4.id];
            Debug.Log("Player name: " + player1.name);
        }
    }
}
