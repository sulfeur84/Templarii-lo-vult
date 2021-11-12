using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BONUSMALUS : MonoBehaviour
{
    // Burger BONUS : Faire en sorte qu'il remonte de 25% la barre de vie : variable = variable-variable*25/100
    
    // Burger MALUS : Faire en sorte qu'il perd 1% de point de vie par seconde : variable = variable-variable*1/100

    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Destroy(gameObject);
            
        }
    }
}
