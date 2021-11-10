using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PiouPiou : MonoBehaviour
{
    public Animator animator;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            animator.SetTrigger("Slash");
        }
    }
}
