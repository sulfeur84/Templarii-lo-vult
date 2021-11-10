using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class BaboucheScript : MonoBehaviour
{

    public float targetTime = 2.0f;
        public GameObject Bazook, Babouche;
        public GameObject Ballbouche;
 
        void Update(){
            var gamepad = Gamepad.current;
            targetTime -= Time.deltaTime;
 
            if (targetTime <= 0.0f)
            {
                timerEnded();
            }


if (UnityEngine.InputSystem.Gamepad.current is UnityEngine.InputSystem.XInput.XInputController)
{
    if (gamepad.xButton.wasPressedThisFrame)
    {
        Instantiate(Ballbouche, transform.position, transform.rotation);
    }
}
 
        }
 
        void timerEnded()
        {
            targetTime = 2.0f;
            Bazook.gameObject.SetActive(true);
            Babouche.gameObject.SetActive(false);
        }
        
    }

