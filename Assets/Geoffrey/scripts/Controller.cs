using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.XInput;

public class Controller : MonoBehaviour
{
    [SerializeField]
    private float _speed = 10f;
    private Vector3 _move;
    private Rigidbody rb;
    Vector3 rawInputMovement;
    public Templariilovult controls;

    void Awake()
    {
        controls.Player.Move.performed += context => MovePlayer(context.ReadValue<Vector3>());
        //controls.Player.Attack.performed += context => Attack(context.ReadValue<>());
        //controls.Player.SuperAttack.performed += context => AttackSpe(context.ReadValue<>());
        //controls.Player.Interract.performed += context => Interract(context.ReadValue<>());
        //controls.Player.Look.performed += context => LookAt(context.ReadValue<>());
    }
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
        
    }

    public void MovePlayer(Vector3 dir)
    {
        rb.MovePosition(rb.position + dir * _speed * Time.fixedDeltaTime);
        
    }
    public void Attack(InputAction.CallbackContext context)
    {
        Debug.Log("X Button is pressed.");
    }
    public void AttackSpe(InputAction.CallbackContext context)
    {
        Debug.Log("Y Button is pressed.");
    }
    public void HelpFriend(InputAction.CallbackContext context)
    {
        Debug.Log("B Button is pressed.");
    }
    public void Interract(InputAction.CallbackContext context)
    {
        Debug.Log("A Button is pressed.");
    }
    public void LookAt(InputAction.CallbackContext context)
    {
        if (Gamepad.current.rightStick.x.IsActuated())
        {
            transform.Rotate(0, Gamepad.current.rightStick.x.ReadValue(), 0);
        }
        if (Gamepad.current.rightStick.y.IsActuated())
        {
            transform.Rotate(0, Gamepad.current.rightStick.y.ReadValue(), 0);
        }
    }
}
