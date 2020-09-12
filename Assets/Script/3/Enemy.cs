using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    private UIManagar _ui;
   public void OnEnable()
   {
       SpawnManager.enemyCount++;
        _ui = GameObject.Find("UI_Managar").GetComponent<UIManagar>();
        _ui.UpdateEnemyCount();
       Die();
   }
   
   public void OnDisable()
   {
       SpawnManager.enemyCount--;
       _ui.UpdateEnemyCount();
   }

   void Die()
   {
       Destroy(this.gameObject, Random.Range(2, 6));
   }
}
