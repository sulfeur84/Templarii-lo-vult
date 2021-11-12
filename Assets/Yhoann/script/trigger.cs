using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trigger : MonoBehaviour
{
    public GameObject Enemy;

    public Transform Spawner;
    // Start is called before the first frame update
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            Instantiate(Enemy, Spawner.transform.position, transform.rotation);
            Debug.Log("hello");
        }
    }
}
