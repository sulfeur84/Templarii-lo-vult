using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Checkpoint : MonoBehaviour
{
    public Animator Anim;
    public bool IsOn = false;
    private Vector3 Checkpoin = new Vector3(0, 0 , 0);
    public GameObject SpwnPoint;

    public void Start()
    {
        Checkpoin = SpwnPoint.gameObject.transform.position;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            RespawnScript.Apparition = Checkpoin;
            Anim.SetTrigger("Drapo");
        }
        
    }
    
}
