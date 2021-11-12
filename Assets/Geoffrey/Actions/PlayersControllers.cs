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
                    ""type"": ""Button"",
                    ""id"": ""abc7b79f-1224-4510-9408-3602ed624f02"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Look"",
                    ""type"": ""Button"",
                    ""id"": ""76ea7991-b776-417b-a013-1c5535a11a0f"",
                    ""expectedControlType"": ""Button"",
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
                    ""name"": ""Interract"",
                    ""type"": ""Button"",
                    ""id"": ""a4f03e12-914b-4933-83d6-c486af9a7b0d"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""442a0ec1-f810-4495-8823-e153a8430bef"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""cec598c7-25d3-4693-a492-a874b52e4f16"",
                    ""path"": ""<XInputController>/leftStick/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""XboxGamepad"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""c81374fc-1c26-4692-aaa7-198a767a9c81"",
                    ""path"": ""<XInputController>/leftStick/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""XboxGamepad"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""6f3c83bc-c91e-4626-840f-343aaad982cc"",
                    ""path"": ""<XInputController>/leftStick/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""XboxGamepad"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""aeca4c9d-b1b5-4a23-85e2-6bf11245f49d"",
                    ""path"": ""<XInputController>/leftStick/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""XboxGamepad"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""666ef0d5-72eb-413a-b2c5-841d1bbe7143"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Look"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""26c4ab92-d89e-47cc-ae7d-7a9482a5122e"",
                    ""path"": ""<XInputController>/rightStick/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""XboxGamepad"",
                    ""action"": ""Look"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""3c92a299-f151-4b33-b265-28125f5699df"",
                    ""path"": ""<XInputController>/rightStick/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""XboxGamepad"",
                    ""action"": ""Look"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""5a70c63b-c62f-4fe7-b5cf-c24d71711dec"",
                    ""path"": ""<XInputController>/rightStick/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""XboxGamepad"",
                    ""action"": ""Look"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""f14d3fb2-9285-4f59-8ea0-8fa0c62b1cc9"",
                    ""path"": ""<XInputController>/rightStick/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""XboxGamepad"",
                    ""action"": ""Look"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""cbe374ff-8d2b-4a9b-acd7-d0cfc29c9283"",
                    ""path"": ""<XInputController>/buttonWest"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""XboxGamepad"",
                    ""action"": ""Attack"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""8cc279ad-28c9-4fb6-9292-46b3339ec30c"",
                    ""path"": ""<XInputController>/buttonNorth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""XboxGamepad"",
                    ""action"": ""Attack Spe"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""3f58dd95-cd19-4600-ad81-030eced5eae1"",
                    ""path"": ""<XInputController>/buttonEast"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""XboxGamepad"",
                    ""action"": ""HelpFriend"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""d9a962bb-d044-41ba-94d8-cb76abd32455"",
                    ""path"": ""<XInputController>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""XboxGamepad"",
                    ""action"": ""Interract"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""XboxGamepad"",
            ""bindingGroup"": ""XboxGamepad"",
            ""devices"": [
                {
                    ""devicePath"": ""<XboxOneGampadiOS>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        }
    ]
}");
        // Player
        m_Player = asset.FindActionMap("Player", throwIfNotFound: true);
        m_Player_Move = m_Player.FindAction("Move", throwIfNotFound: true);
        m_Player_Look = m_Player.FindAction("Look", throwIfNotFound: true);
        m_Player_Attack = m_Player.FindAction("Attack", throwIfNotFound: true);
        m_Player_AttackSpe = m_Player.FindAction("Attack Spe", throwIfNotFound: true);
        m_Player_HelpFriend = m_Player.FindAction("HelpFriend", throwIfNotFound: true);
        m_Player_Interract = m_Player.FindAction("Interract", throwIfNotFound: true);
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
    private readonly InputAction m_Player_Interract;
    public struct PlayerActions
    {
        private @PlayersControllers m_Wrapper;
        public PlayerActions(@PlayersControllers wrapper) { m_Wrapper = wrapper; }
        public InputAction @Move => m_Wrapper.m_Player_Move;
        public InputAction @Look => m_Wrapper.m_Player_Look;
        public InputAction @Attack => m_Wrapper.m_Player_Attack;
        public InputAction @AttackSpe => m_Wrapper.m_Player_AttackSpe;
        public InputAction @HelpFriend => m_Wrapper.m_Player_HelpFriend;
        public InputAction @Interract => m_Wrapper.m_Player_Interract;
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
                @Interract.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnInterract;
                @Interract.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnInterract;
                @Interract.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnInterract;
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
                @Interract.started += instance.OnInterract;
                @Interract.performed += instance.OnInterract;
                @Interract.canceled += instance.OnInterract;
            }
        }
    }
    public PlayerActions @Player => new PlayerActions(this);
    private int m_XboxGamepadSchemeIndex = -1;
    public InputControlScheme XboxGamepadScheme
    {
        get
        {
            if (m_XboxGamepadSchemeIndex == -1) m_XboxGamepadSchemeIndex = asset.FindControlSchemeIndex("XboxGamepad");
            return asset.controlSchemes[m_XboxGamepadSchemeIndex];
        }
    }
    public interface IPlayerActions
    {
        void OnMove(InputAction.CallbackContext context);
        void OnLook(InputAction.CallbackContext context);
        void OnAttack(InputAction.CallbackContext context);
        void OnAttackSpe(InputAction.CallbackContext context);
        void OnHelpFriend(InputAction.CallbackContext context);
        void OnInterract(InputAction.CallbackContext context);
    }
}
