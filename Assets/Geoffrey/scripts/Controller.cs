using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.XInput;

public class Controller : MonoBehaviour
{
    private PlayersControllers playerControls;

    [SerializeField]
    private float _speed;
    private Vector3 _move;
    private Rigidbody rb;

    private void Awake()
    {
        playerControls = new PlayersControllers();
    }

    private void OnEnable()
    {
        playerControls.Enable();
    }

    private void OnDisable()
    {
        playerControls.Disable();
        playerControls.Player.Attack.started -= Attack;
        playerControls.Player.Move.started -= MovePlayer;
        playerControls.Player.AttackSpe.started -= AttackSpe;
        playerControls.Player.HelpFriend.started -= HelpFriend;
        playerControls.Player.Interract.started -= Interract;
        playerControls.Player.Look.started -= LookAt;
    }

    void Start()
    {
        playerControls.Player.Move.started += MovePlayer;
        playerControls.Player.Move.performed += MovePlayer;
        playerControls.Player.Move.canceled += MovePlayer;

        playerControls.Player.Attack.started += Attack;
        playerControls.Player.Attack.performed += Attack;
        playerControls.Player.Attack.canceled += Attack;

        playerControls.Player.AttackSpe.started += AttackSpe;
        playerControls.Player.AttackSpe.performed += AttackSpe;
        playerControls.Player.AttackSpe.canceled += AttackSpe;

        playerControls.Player.HelpFriend.started += HelpFriend;
        playerControls.Player.HelpFriend.performed += HelpFriend;
        playerControls.Player.HelpFriend.canceled += HelpFriend;

        playerControls.Player.Interract.started += Interract;
        playerControls.Player.Interract.performed += Interract;
        playerControls.Player.Interract.canceled += Interract;

        playerControls.Player.Look.started += LookAt;
        playerControls.Player.Look.performed += LookAt;
        playerControls.Player.Look.canceled += LookAt;

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

    public void MovePlayer(InputAction.CallbackContext context)
    {
        rb.MovePosition(rb.position + _move * _speed * Time.fixedDeltaTime);
        
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
        transform.Rotate(0, Gamepad.current.rightStick.x.ReadValue() + Gamepad.current.rightStick.y.ReadValue(), 0);        
    }

    public void Attack(InputAction.CallbackContext context)
    {
        Debug.Log("X Button is pressed.");
    }
}
