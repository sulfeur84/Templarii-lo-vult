// GENERATED AUTOMATICALLY FROM 'Assets/Geoffrey/Actions/PlayersControllers.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @PlayersControllers : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayersControllers()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayersControllers"",
    ""maps"": [
        {
            ""name"": ""Player"",
            ""id"": ""63a2bb25-6a0c-42fa-8921-311737f2939d"",
            ""actions"": [
                {
                    ""name"": ""Move"",
                    ""type"": ""Value"",
                    ""id"": ""abc7b79f-1224-4510-9408-3602ed624f02"",
                    ""expectedControlType"": ""Stick"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Look"",
                    ""type"": ""Value"",
                    ""id"": ""76ea7991-b776-417b-a013-1c5535a11a0f"",
                    ""expectedControlType"": ""Stick"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Attack"",
                    ""type"": ""Button"",
                    ""id"": ""6dffa4ae-c7e3-4cec-bea7-948f659de27c"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Attack Spe"",
                    ""type"": ""Button"",
                    ""id"": ""1389e298-261c-41a0-8931-af055b9f70d1"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""HelpFriend"",
                    ""type"": ""Button"",
                    ""id"": ""aea18a87-2c3c-483f-a3c3-40fe40cb42e6"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Interact"",
                    ""type"": ""Button"",
                    ""id"": ""a4f03e12-914b-4933-83d6-c486af9a7b0d"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Start"",
                    ""type"": ""Button"",
                    ""id"": ""0d3b7197-b932-4158-8a2d-374c0c13010a"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""2cc35c76-3c66-42ba-b9bc-7b5d10970c1c"",
                    ""path"": ""<Gamepad>/rightStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Look"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""2bb77623-e841-45da-a29a-11a55083a46a"",
                    ""path"": ""<Gamepad>/buttonWest"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Attack"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""9dd46818-bfa2-48e6-af0a-ce239f9c7af5"",
                    ""path"": ""<Gamepad>/buttonNorth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Attack Spe"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""8a14f1fc-9a76-4dae-b85b-e2f96fb00ade"",
                    ""path"": ""<DualShockGamepad>/buttonEast"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""HelpFriend"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""65cfe2c2-8dde-4827-b702-2cb4e995a3e0"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Interact"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""b70a7aac-50ca-43a1-a2be-16db8b987da9"",
                    ""path"": ""<Gamepad>/leftStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""851f43aa-8850-4bf1-aad6-595e36a3faf4"",
                    ""path"": ""<Gamepad>/start"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Start"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Player
        m_Player = asset.FindActionMap("Player", throwIfNotFound: true);
        m_Player_Move = m_Player.FindAction("Move", throwIfNotFound: true);
        m_Player_Look = m_Player.FindAction("Look", throwIfNotFound: true);
        m_Player_Attack = m_Player.FindAction("Attack", throwIfNotFound: true);
        m_Player_AttackSpe = m_Player.FindAction("Attack Spe", throwIfNotFound: true);
        m_Player_HelpFriend = m_Player.FindAction("HelpFriend", throwIfNotFound: true);
        m_Player_Interact = m_Player.FindAction("Interact", throwIfNotFound: true);
        m_Player_Start = m_Player.FindAction("Start", throwIfNotFound: true);
    }

    public void Dispose()
    {
        UnityEngine.Object.Destroy(asset);
    }

    public InputBinding? bindingMask
    {
        get => asset.bindingMask;
        set => asset.bindingMask = value;
    }

    public ReadOnlyArray<InputDevice>? devices
    {
        get => asset.devices;
        set => asset.devices = value;
    }

    public ReadOnlyArray<InputControlScheme> controlSchemes => asset.controlSchemes;

    public bool Contains(InputAction action)
    {
        return asset.Contains(action);
    }

    public IEnumerator<InputAction> GetEnumerator()
    {
        return asset.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    public void Enable()
    {
        asset.Enable();
    }

    public void Disable()
    {
        asset.Disable();
    }

    // Player
    private readonly InputActionMap m_Player;
    private IPlayerActions m_PlayerActionsCallbackInterface;
    private readonly InputAction m_Player_Move;
    private readonly InputAction m_Player_Look;
    private readonly InputAction m_Player_Attack;
    private readonly InputAction m_Player_AttackSpe;
    private readonly InputAction m_Player_HelpFriend;
    private readonly InputAction m_Player_Interact;
    private readonly InputAction m_Player_Start;
    public struct PlayerActions
    {
        private @PlayersControllers m_Wrapper;
        public PlayerActions(@PlayersControllers wrapper) { m_Wrapper = wrapper; }
        public InputAction @Move => m_Wrapper.m_Player_Move;
        public InputAction @Look => m_Wrapper.m_Player_Look;
        public InputAction @Attack => m_Wrapper.m_Player_Attack;
        public InputAction @AttackSpe => m_Wrapper.m_Player_AttackSpe;
        public InputAction @HelpFriend => m_Wrapper.m_Player_HelpFriend;
        public InputAction @Interact => m_Wrapper.m_Player_Interact;
        public InputAction @Start => m_Wrapper.m_Player_Start;
        public InputActionMap Get() { return m_Wrapper.m_Player; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlayerActions set) { return set.Get(); }
        public void SetCallbacks(IPlayerActions instance)
        {
            if (m_Wrapper.m_PlayerActionsCallbackInterface != null)
            {
                @Move.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMove;
                @Move.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMove;
                @Move.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMove;
                @Look.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnLook;
                @Look.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnLook;
                @Look.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnLook;
                @Attack.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnAttack;
                @Attack.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnAttack;
                @Attack.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnAttack;
                @AttackSpe.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnAttackSpe;
                @AttackSpe.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnAttackSpe;
                @AttackSpe.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnAttackSpe;
                @HelpFriend.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnHelpFriend;
                @HelpFriend.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnHelpFriend;
                @HelpFriend.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnHelpFriend;
                @Interact.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnInteract;
                @Interact.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnInteract;
                @Interact.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnInteract;
                @Start.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnStart;
                @Start.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnStart;
                @Start.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnStart;
            }
            m_Wrapper.m_PlayerActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Move.started += instance.OnMove;
                @Move.performed += instance.OnMove;
                @Move.canceled += instance.OnMove;
                @Look.started += instance.OnLook;
                @Look.performed += instance.OnLook;
                @Look.canceled += instance.OnLook;
                @Attack.started += instance.OnAttack;
                @Attack.performed += instance.OnAttack;
                @Attack.canceled += instance.OnAttack;
                @AttackSpe.started += instance.OnAttackSpe;
                @AttackSpe.performed += instance.OnAttackSpe;
                @AttackSpe.canceled += instance.OnAttackSpe;
                @HelpFriend.started += instance.OnHelpFriend;
                @HelpFriend.performed += instance.OnHelpFriend;
                @HelpFriend.canceled += instance.OnHelpFriend;
                @Interact.started += instance.OnInteract;
                @Interact.performed += instance.OnInteract;
                @Interact.canceled += instance.OnInteract;
                @Start.started += instance.OnStart;
                @Start.performed += instance.OnStart;
                @Start.canceled += instance.OnStart;
            }
        }
    }
    public PlayerActions @Player => new PlayerActions(this);
    public interface IPlayerActions
    {
        void OnMove(InputAction.CallbackContext context);
        void OnLook(InputAction.CallbackContext context);
        void OnAttack(InputAction.CallbackContext context);
        void OnAttackSpe(InputAction.CallbackContext context);
        void OnHelpFriend(InputAction.CallbackContext context);
        void OnInteract(InputAction.CallbackContext context);
        void OnStart(InputAction.CallbackContext context);
    }
}
