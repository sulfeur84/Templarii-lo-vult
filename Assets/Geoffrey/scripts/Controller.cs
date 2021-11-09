using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Controller : MonoBehaviour
{
    [SerializeField]
    private float _speed = 2f;
    private Vector3 _move;
    private Rigidbody rb;
    Vector3 rawInputMovement;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    
    void FixedUpdate()
    {
        var gamepad = Gamepad.current;
        if (gamepad == null)
        {
            Debug.Log("No controller detected.");
            return;
        }
        
        _move.x = gamepad.leftStick.x.ReadValue();
        _move.y = 0f;
        _move.z = gamepad.leftStick.y.ReadValue();
        
        if (gamepad.leftStick.left.wasPressedThisFrame  || gamepad.leftStick.right.wasPressedThisFrame || 
            gamepad.leftStick.down.wasPressedThisFrame|| gamepad.leftStick.up.wasPressedThisFrame)
        {
            rb.MovePosition(rb.position + _move * _speed * Time.fixedDeltaTime);
        }
        
        if (gamepad.buttonWest.wasPressedThisFrame)
        {
            
        }
        if (gamepad.buttonEast.wasPressedThisFrame)
        {
            
        }
        if (gamepad.buttonNorth.wasPressedThisFrame)
        {
            
        }
        if (gamepad.buttonSouth.wasPressedThisFrame)
        {
            
        }
    }
    
}
