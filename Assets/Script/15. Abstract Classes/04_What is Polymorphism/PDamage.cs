using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface PDamage
{
   int Health {get; set;}
   void Damage (int damageAmount);
}
