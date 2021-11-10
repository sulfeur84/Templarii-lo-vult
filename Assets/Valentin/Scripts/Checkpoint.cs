using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Checkpoint : MonoBehaviour
{
    public Animator Anim;
    public bool IsOn = false;
    Vector3 apparition = new Vector3(0,1,10);
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Anim.SetTrigger("Drapo");
            IsOn = true;
        }
        
    }

    private void Update()
    {

        if (IsOn)
        {
          
        }
    }
}
