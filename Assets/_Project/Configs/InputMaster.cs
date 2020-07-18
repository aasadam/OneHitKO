// GENERATED AUTOMATICALLY FROM 'Assets/_Project/Configs/InputMaster.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @InputMaster : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @InputMaster()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""InputMaster"",
    ""maps"": [
        {
            ""name"": ""Player"",
            ""id"": ""c84960ad-8d5f-456d-8b0e-7eeccfef03e5"",
            ""actions"": [
                {
                    ""name"": ""SelfHability"",
                    ""type"": ""PassThrough"",
                    ""id"": ""70104fdd-bd19-4522-9b9b-6fc07e8aa7c8"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Movement"",
                    ""type"": ""PassThrough"",
                    ""id"": ""cc5c71b2-ae3d-48a3-9124-de206453223a"",
                    ""expectedControlType"": ""Dpad"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""PointerPosition"",
                    ""type"": ""Value"",
                    ""id"": ""22a2cde2-9b3d-4ee7-a362-75f8d6fc3f63"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Skill1"",
                    ""type"": ""Button"",
                    ""id"": ""8aa1eea4-3e2d-48aa-9787-057d13a97dfa"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Skill3"",
                    ""type"": ""Button"",
                    ""id"": ""74bab896-265b-45e9-b3e1-01745170f666"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""b5ca5669-192f-491f-94fd-0a7064bfbc26"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""BoardMouse"",
                    ""action"": ""SelfHability"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""5013f1e2-dfd2-4e78-955d-cf3354d9b414"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": ""NormalizeVector2"",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""2932571e-639b-46d6-a98c-556922855a41"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""BoardMouse"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""a5c279ec-f95e-4118-8b05-3787393b281c"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""BoardMouse"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""fc3f7138-b508-432c-8ded-ca44c600a841"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""BoardMouse"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""c3a7e1ac-6e2d-4940-974a-e7ce6798d234"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""BoardMouse"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""620f9207-89ae-4c12-a8c0-2a3b382b02ad"",
                    ""path"": ""<Pointer>/position"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""BoardMouse;Touch"",
                    ""action"": ""PointerPosition"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""c0cdf0fb-113c-420b-9088-86d39b6399d0"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": ""Press"",
                    ""processors"": """",
                    ""groups"": ""BoardMouse"",
                    ""action"": ""Skill1"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""01969243-3352-41b1-a9b3-b4bf4e6904db"",
                    ""path"": ""<Mouse>/rightButton"",
                    ""interactions"": ""Press"",
                    ""processors"": """",
                    ""groups"": ""BoardMouse"",
                    ""action"": ""Skill3"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""BoardMouse"",
            ""bindingGroup"": ""BoardMouse"",
            ""devices"": [
                {
                    ""devicePath"": ""<Keyboard>"",
                    ""isOptional"": false,
                    ""isOR"": false
                },
                {
                    ""devicePath"": ""<Mouse>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        },
        {
            ""name"": ""Touch"",
            ""bindingGroup"": ""Touch"",
            ""devices"": [
                {
                    ""devicePath"": ""<Touchscreen>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        }
    ]
}");
        // Player
        m_Player = asset.FindActionMap("Player", throwIfNotFound: true);
        m_Player_SelfHability = m_Player.FindAction("SelfHability", throwIfNotFound: true);
        m_Player_Movement = m_Player.FindAction("Movement", throwIfNotFound: true);
        m_Player_PointerPosition = m_Player.FindAction("PointerPosition", throwIfNotFound: true);
        m_Player_Skill1 = m_Player.FindAction("Skill1", throwIfNotFound: true);
        m_Player_Skill3 = m_Player.FindAction("Skill3", throwIfNotFound: true);
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
    private readonly InputAction m_Player_SelfHability;
    private readonly InputAction m_Player_Movement;
    private readonly InputAction m_Player_PointerPosition;
    private readonly InputAction m_Player_Skill1;
    private readonly InputAction m_Player_Skill3;
    public struct PlayerActions
    {
        private @InputMaster m_Wrapper;
        public PlayerActions(@InputMaster wrapper) { m_Wrapper = wrapper; }
        public InputAction @SelfHability => m_Wrapper.m_Player_SelfHability;
        public InputAction @Movement => m_Wrapper.m_Player_Movement;
        public InputAction @PointerPosition => m_Wrapper.m_Player_PointerPosition;
        public InputAction @Skill1 => m_Wrapper.m_Player_Skill1;
        public InputAction @Skill3 => m_Wrapper.m_Player_Skill3;
        public InputActionMap Get() { return m_Wrapper.m_Player; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlayerActions set) { return set.Get(); }
        public void SetCallbacks(IPlayerActions instance)
        {
            if (m_Wrapper.m_PlayerActionsCallbackInterface != null)
            {
                @SelfHability.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnSelfHability;
                @SelfHability.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnSelfHability;
                @SelfHability.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnSelfHability;
                @Movement.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMovement;
                @Movement.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMovement;
                @Movement.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMovement;
                @PointerPosition.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnPointerPosition;
                @PointerPosition.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnPointerPosition;
                @PointerPosition.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnPointerPosition;
                @Skill1.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnSkill1;
                @Skill1.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnSkill1;
                @Skill1.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnSkill1;
                @Skill3.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnSkill3;
                @Skill3.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnSkill3;
                @Skill3.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnSkill3;
            }
            m_Wrapper.m_PlayerActionsCallbackInterface = instance;
            if (instance != null)
            {
                @SelfHability.started += instance.OnSelfHability;
                @SelfHability.performed += instance.OnSelfHability;
                @SelfHability.canceled += instance.OnSelfHability;
                @Movement.started += instance.OnMovement;
                @Movement.performed += instance.OnMovement;
                @Movement.canceled += instance.OnMovement;
                @PointerPosition.started += instance.OnPointerPosition;
                @PointerPosition.performed += instance.OnPointerPosition;
                @PointerPosition.canceled += instance.OnPointerPosition;
                @Skill1.started += instance.OnSkill1;
                @Skill1.performed += instance.OnSkill1;
                @Skill1.canceled += instance.OnSkill1;
                @Skill3.started += instance.OnSkill3;
                @Skill3.performed += instance.OnSkill3;
                @Skill3.canceled += instance.OnSkill3;
            }
        }
    }
    public PlayerActions @Player => new PlayerActions(this);
    private int m_BoardMouseSchemeIndex = -1;
    public InputControlScheme BoardMouseScheme
    {
        get
        {
            if (m_BoardMouseSchemeIndex == -1) m_BoardMouseSchemeIndex = asset.FindControlSchemeIndex("BoardMouse");
            return asset.controlSchemes[m_BoardMouseSchemeIndex];
        }
    }
    private int m_TouchSchemeIndex = -1;
    public InputControlScheme TouchScheme
    {
        get
        {
            if (m_TouchSchemeIndex == -1) m_TouchSchemeIndex = asset.FindControlSchemeIndex("Touch");
            return asset.controlSchemes[m_TouchSchemeIndex];
        }
    }
    public interface IPlayerActions
    {
        void OnSelfHability(InputAction.CallbackContext context);
        void OnMovement(InputAction.CallbackContext context);
        void OnPointerPosition(InputAction.CallbackContext context);
        void OnSkill1(InputAction.CallbackContext context);
        void OnSkill3(InputAction.CallbackContext context);
    }
}
