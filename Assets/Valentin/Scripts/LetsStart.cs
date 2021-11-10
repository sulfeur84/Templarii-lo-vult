using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
public class LetsStart : MonoBehaviour
{
    public Cameraman cam;
    void Update()
    {
        var gamepad = Gamepad.current;
        if (gamepad.aButton.wasPressedThisFrame)
        {
            cam.enabled = true;
        }
    }
}
