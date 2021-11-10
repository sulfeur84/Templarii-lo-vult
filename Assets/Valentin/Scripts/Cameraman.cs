using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.XInput;
public class Cameraman : MonoBehaviour
{
[SerializeField]
    private float _speed = 10f;
    private Vector3 _move;
    private Rigidbody rb;
    Vector3 rawInputMovement;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    
    void Update()
    {
        var gamepad = Gamepad.current;
        if (gamepad == null)
        {
            Debug.Log("No controller detected.");
            return;
        }

        _move.x = gamepad.leftStick.x.ReadValue();
        _move.z = gamepad.leftStick.y.ReadValue();
        

        if (UnityEngine.InputSystem.Gamepad.current is UnityEngine.InputSystem.XInput.XInputController)
        {
            if (gamepad.leftStick.IsActuated())
            {
                rb.MovePosition(rb.position + _move * _speed * Time.fixedDeltaTime);
            }

            if (gamepad.xButton.wasPressedThisFrame)
            {
                Debug.Log("X Button is pressed.");
            }
            if (gamepad.bButton.wasPressedThisFrame)
            {
                Debug.Log("B Button is pressed.");
            }
            if (gamepad.yButton.wasPressedThisFrame)
            {
                Debug.Log("Y Button is pressed.");
            }
            if (gamepad.aButton.wasPressedThisFrame)
            {
                Debug.Log("A Button is pressed.");
            }
        }
        
        if (UnityEngine.InputSystem.Gamepad.current is UnityEngine.InputSystem.DualShock.DualShockGamepad)
        {
            if (gamepad.leftStick.IsActuated())
            {
                rb.MovePosition(rb.position + _move * _speed * Time.fixedDeltaTime);
            }
            if (gamepad.squareButton.wasPressedThisFrame)
            {
                Debug.Log("Square Button is pressed.");
            }
            if (gamepad.circleButton.wasPressedThisFrame)
            {
                Debug.Log("Circle Button is pressed.");
            }
            if (gamepad.triangleButton.wasPressedThisFrame)
            {
                Debug.Log("Triangle Button is pressed.");
            }
            if (gamepad.crossButton.wasPressedThisFrame)
            {
                Debug.Log("Cross Button is pressed.");
            }
        }
    }
}


