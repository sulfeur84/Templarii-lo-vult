using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BonusArmeTemp : MonoBehaviour
{
    public GameObject Bazook, Babouche;
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Bazook.gameObject.SetActive(false);
            Babouche.gameObject.SetActive(true);
            Destroy(gameObject);
        }
    }
}
