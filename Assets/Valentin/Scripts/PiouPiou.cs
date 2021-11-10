using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PiouPiou : MonoBehaviour
{
    public Animator animator;

    void Update()
    {
        var gamepad = Gamepad.current;
        if (UnityEngine.InputSystem.Gamepad.current is UnityEngine.InputSystem.XInput.XInputController)
        {
            if (gamepad.xButton.wasPressedThisFrame)
            {
                animator.SetTrigger("Slash");
            }
        }
    }
}
