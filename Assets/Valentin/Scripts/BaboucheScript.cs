using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaboucheScript : MonoBehaviour
{

    public float targetTime = 2.0f;
        public GameObject Bazook, Babouche;
        public GameObject Ballbouche;
 
        void Update(){
 
            targetTime -= Time.deltaTime;
 
            if (targetTime <= 0.0f)
            {
                timerEnded();
            }

            if (Input.GetKeyDown(KeyCode.Space))
            {
                Instantiate(Ballbouche, transform.position, transform.rotation);
            }
 
        }
 
        void timerEnded()
        {
            targetTime = 2.0f;
            Bazook.gameObject.SetActive(true);
            Babouche.gameObject.SetActive(false);
        }
        
    }

