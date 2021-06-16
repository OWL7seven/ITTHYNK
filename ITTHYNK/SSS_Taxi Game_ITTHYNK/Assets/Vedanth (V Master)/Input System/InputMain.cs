// GENERATED AUTOMATICALLY FROM 'Assets/Vedanth (V Master)/Input System/InputMain.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @InputMain : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @InputMain()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""InputMain"",
    ""maps"": [
        {
            ""name"": ""PlayerTaxi"",
            ""id"": ""06e4bb4b-2fb6-443c-9e5f-79297f0b8af7"",
            ""actions"": [
                {
                    ""name"": ""Accelerate"",
                    ""type"": ""Value"",
                    ""id"": ""d3fdb110-20c7-435c-9d26-3f6402973335"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Reverse"",
                    ""type"": ""Value"",
                    ""id"": ""f073d2c7-4ef8-4a4a-a61e-6523fc054f5c"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Drift"",
                    ""type"": ""Button"",
                    ""id"": ""0645d133-0e23-43cf-a451-72ff88328ee2"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Turning"",
                    ""type"": ""Value"",
                    ""id"": ""435ff4fb-d0d9-4d97-a680-0b2f153d8d1d"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Boost"",
                    ""type"": ""Button"",
                    ""id"": ""d7a52759-ae1c-4228-b5db-8dfd427a13bf"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Jump"",
                    ""type"": ""Button"",
                    ""id"": ""cd6d92ec-7939-463f-a774-ad8dc3d48b3b"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""4d6e640c-acc5-4638-95fc-57fd19302f2a"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Accelerate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""da03dcd0-37b7-4be7-9838-6236bf742029"",
                    ""path"": ""<DualShockGamepad>/rightTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Playstation"",
                    ""action"": ""Accelerate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""c6548621-9e7b-4538-9b1e-a45414bc406a"",
                    ""path"": ""<XInputController>/rightTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Xbox"",
                    ""action"": ""Accelerate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""8a08ab60-87ef-4972-a2aa-9c1390b66b48"",
                    ""path"": ""<SwitchProControllerHID>/rightTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Switch "",
                    ""action"": ""Accelerate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""00a5fd5f-f9b8-4af5-84cf-0992a9de58fd"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Reverse"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""6a616e92-7fb6-44fe-bbc7-38e558f25172"",
                    ""path"": ""<DualShockGamepad>/leftTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Playstation"",
                    ""action"": ""Reverse"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""ea814852-1f16-4b13-a6e5-9abb68f96119"",
                    ""path"": ""<XInputController>/leftTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Xbox"",
                    ""action"": ""Reverse"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""1edda1ad-0850-48a0-8e91-95eace1c5034"",
                    ""path"": ""<SwitchProControllerHID>/leftTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Switch "",
                    ""action"": ""Reverse"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""b17c90e2-dedc-46a5-893e-d4732e8202c3"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Drift"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""86b86148-7fa5-465f-80c1-ae5c99d3aaa3"",
                    ""path"": ""<DualShockGamepad>/buttonEast"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Playstation"",
                    ""action"": ""Drift"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""28691e74-6a76-4599-af5e-ff46555fbd89"",
                    ""path"": ""<XInputController>/buttonEast"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Xbox"",
                    ""action"": ""Drift"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""Keyboard"",
                    ""id"": ""e7e58843-5636-4487-8ee4-21062361396e"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Turning"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""d99f725a-5e3b-487c-9dbd-24c54d34980c"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Turning"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""565847fc-d3ba-429b-9503-f13cd334567e"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Turning"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""PS4"",
                    ""id"": ""01d81a25-3f0d-4986-8a91-48c6f72565c5"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Turning"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""e1d953e0-ecef-4dbb-9670-aea5c4ec9adf"",
                    ""path"": ""<DualShockGamepad>/leftStick/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Playstation"",
                    ""action"": ""Turning"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""51811573-3d32-472a-96ee-c7d6045311a0"",
                    ""path"": ""<DualShockGamepad>/leftStick/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Playstation"",
                    ""action"": ""Turning"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Xbox"",
                    ""id"": ""4bf0c535-3e29-43f5-9966-edcc3c3c9bff"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Turning"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""486acc61-67dd-40ca-b6a3-bc5482a53884"",
                    ""path"": ""<XInputController>/leftStick/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Xbox"",
                    ""action"": ""Turning"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""530b86e9-0082-4bd3-9ed6-7c257aba7b16"",
                    ""path"": ""<XInputController>/leftStick/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Xbox"",
                    ""action"": ""Turning"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Switch"",
                    ""id"": ""81beb345-2617-4fa8-80c3-9bb12dbd3eb7"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Turning"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""187c708e-de56-45e9-8191-d9c4628e917f"",
                    ""path"": ""<SwitchProControllerHID>/leftStick/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Switch "",
                    ""action"": ""Turning"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""1756727c-b532-462c-a147-f0dd33d7e698"",
                    ""path"": ""<SwitchProControllerHID>/leftStick/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Switch "",
                    ""action"": ""Turning"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""5f104799-016f-4edf-a135-ec3dc0a82d03"",
                    ""path"": ""<SwitchProControllerHID>/buttonEast"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Switch "",
                    ""action"": ""Drift"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""a3c5d902-8c0e-45aa-8ced-df7e58a23d1d"",
                    ""path"": ""<Keyboard>/leftShift"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Boost"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""91613c10-3341-4955-b26b-f11f1ee4abd0"",
                    ""path"": ""<DualShockGamepad>/buttonWest"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Playstation"",
                    ""action"": ""Boost"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""fd52532d-a5a9-482a-9938-66bbfe7ee783"",
                    ""path"": ""<XInputController>/buttonWest"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Xbox"",
                    ""action"": ""Boost"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""0df1c68e-0e78-427e-9cdc-b3f5bb410255"",
                    ""path"": ""<SwitchProControllerHID>/buttonWest"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Switch "",
                    ""action"": ""Boost"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""3848bf37-1f77-40ee-8aab-55f315063d5f"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""bc80d28e-ac31-4ff8-beb0-b0457c03210d"",
                    ""path"": ""<DualShockGamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Playstation"",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""98c1d8d6-c568-4eeb-b6c8-e81c55917b55"",
                    ""path"": ""<XInputController>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Xbox"",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""11fe2c69-ce68-41cf-a69f-2c902648362d"",
                    ""path"": ""<SwitchProControllerHID>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Switch "",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""Keyboard"",
            ""bindingGroup"": ""Keyboard"",
            ""devices"": [
                {
                    ""devicePath"": ""<Keyboard>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        },
        {
            ""name"": ""Playstation"",
            ""bindingGroup"": ""Playstation"",
            ""devices"": [
                {
                    ""devicePath"": ""<DualShockGamepad>"",
                    ""isOptional"": true,
                    ""isOR"": false
                }
            ]
        },
        {
            ""name"": ""Xbox"",
            ""bindingGroup"": ""Xbox"",
            ""devices"": [
                {
                    ""devicePath"": ""<XInputController>"",
                    ""isOptional"": true,
                    ""isOR"": false
                }
            ]
        },
        {
            ""name"": ""Switch "",
            ""bindingGroup"": ""Switch "",
            ""devices"": [
                {
                    ""devicePath"": ""<SwitchProControllerHID>"",
                    ""isOptional"": true,
                    ""isOR"": false
                }
            ]
        }
    ]
}");
        // PlayerTaxi
        m_PlayerTaxi = asset.FindActionMap("PlayerTaxi", throwIfNotFound: true);
        m_PlayerTaxi_Accelerate = m_PlayerTaxi.FindAction("Accelerate", throwIfNotFound: true);
        m_PlayerTaxi_Reverse = m_PlayerTaxi.FindAction("Reverse", throwIfNotFound: true);
        m_PlayerTaxi_Drift = m_PlayerTaxi.FindAction("Drift", throwIfNotFound: true);
        m_PlayerTaxi_Turning = m_PlayerTaxi.FindAction("Turning", throwIfNotFound: true);
        m_PlayerTaxi_Boost = m_PlayerTaxi.FindAction("Boost", throwIfNotFound: true);
        m_PlayerTaxi_Jump = m_PlayerTaxi.FindAction("Jump", throwIfNotFound: true);
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

    // PlayerTaxi
    private readonly InputActionMap m_PlayerTaxi;
    private IPlayerTaxiActions m_PlayerTaxiActionsCallbackInterface;
    private readonly InputAction m_PlayerTaxi_Accelerate;
    private readonly InputAction m_PlayerTaxi_Reverse;
    private readonly InputAction m_PlayerTaxi_Drift;
    private readonly InputAction m_PlayerTaxi_Turning;
    private readonly InputAction m_PlayerTaxi_Boost;
    private readonly InputAction m_PlayerTaxi_Jump;
    public struct PlayerTaxiActions
    {
        private @InputMain m_Wrapper;
        public PlayerTaxiActions(@InputMain wrapper) { m_Wrapper = wrapper; }
        public InputAction @Accelerate => m_Wrapper.m_PlayerTaxi_Accelerate;
        public InputAction @Reverse => m_Wrapper.m_PlayerTaxi_Reverse;
        public InputAction @Drift => m_Wrapper.m_PlayerTaxi_Drift;
        public InputAction @Turning => m_Wrapper.m_PlayerTaxi_Turning;
        public InputAction @Boost => m_Wrapper.m_PlayerTaxi_Boost;
        public InputAction @Jump => m_Wrapper.m_PlayerTaxi_Jump;
        public InputActionMap Get() { return m_Wrapper.m_PlayerTaxi; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlayerTaxiActions set) { return set.Get(); }
        public void SetCallbacks(IPlayerTaxiActions instance)
        {
            if (m_Wrapper.m_PlayerTaxiActionsCallbackInterface != null)
            {
                @Accelerate.started -= m_Wrapper.m_PlayerTaxiActionsCallbackInterface.OnAccelerate;
                @Accelerate.performed -= m_Wrapper.m_PlayerTaxiActionsCallbackInterface.OnAccelerate;
                @Accelerate.canceled -= m_Wrapper.m_PlayerTaxiActionsCallbackInterface.OnAccelerate;
                @Reverse.started -= m_Wrapper.m_PlayerTaxiActionsCallbackInterface.OnReverse;
                @Reverse.performed -= m_Wrapper.m_PlayerTaxiActionsCallbackInterface.OnReverse;
                @Reverse.canceled -= m_Wrapper.m_PlayerTaxiActionsCallbackInterface.OnReverse;
                @Drift.started -= m_Wrapper.m_PlayerTaxiActionsCallbackInterface.OnDrift;
                @Drift.performed -= m_Wrapper.m_PlayerTaxiActionsCallbackInterface.OnDrift;
                @Drift.canceled -= m_Wrapper.m_PlayerTaxiActionsCallbackInterface.OnDrift;
                @Turning.started -= m_Wrapper.m_PlayerTaxiActionsCallbackInterface.OnTurning;
                @Turning.performed -= m_Wrapper.m_PlayerTaxiActionsCallbackInterface.OnTurning;
                @Turning.canceled -= m_Wrapper.m_PlayerTaxiActionsCallbackInterface.OnTurning;
                @Boost.started -= m_Wrapper.m_PlayerTaxiActionsCallbackInterface.OnBoost;
                @Boost.performed -= m_Wrapper.m_PlayerTaxiActionsCallbackInterface.OnBoost;
                @Boost.canceled -= m_Wrapper.m_PlayerTaxiActionsCallbackInterface.OnBoost;
                @Jump.started -= m_Wrapper.m_PlayerTaxiActionsCallbackInterface.OnJump;
                @Jump.performed -= m_Wrapper.m_PlayerTaxiActionsCallbackInterface.OnJump;
                @Jump.canceled -= m_Wrapper.m_PlayerTaxiActionsCallbackInterface.OnJump;
            }
            m_Wrapper.m_PlayerTaxiActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Accelerate.started += instance.OnAccelerate;
                @Accelerate.performed += instance.OnAccelerate;
                @Accelerate.canceled += instance.OnAccelerate;
                @Reverse.started += instance.OnReverse;
                @Reverse.performed += instance.OnReverse;
                @Reverse.canceled += instance.OnReverse;
                @Drift.started += instance.OnDrift;
                @Drift.performed += instance.OnDrift;
                @Drift.canceled += instance.OnDrift;
                @Turning.started += instance.OnTurning;
                @Turning.performed += instance.OnTurning;
                @Turning.canceled += instance.OnTurning;
                @Boost.started += instance.OnBoost;
                @Boost.performed += instance.OnBoost;
                @Boost.canceled += instance.OnBoost;
                @Jump.started += instance.OnJump;
                @Jump.performed += instance.OnJump;
                @Jump.canceled += instance.OnJump;
            }
        }
    }
    public PlayerTaxiActions @PlayerTaxi => new PlayerTaxiActions(this);
    private int m_KeyboardSchemeIndex = -1;
    public InputControlScheme KeyboardScheme
    {
        get
        {
            if (m_KeyboardSchemeIndex == -1) m_KeyboardSchemeIndex = asset.FindControlSchemeIndex("Keyboard");
            return asset.controlSchemes[m_KeyboardSchemeIndex];
        }
    }
    private int m_PlaystationSchemeIndex = -1;
    public InputControlScheme PlaystationScheme
    {
        get
        {
            if (m_PlaystationSchemeIndex == -1) m_PlaystationSchemeIndex = asset.FindControlSchemeIndex("Playstation");
            return asset.controlSchemes[m_PlaystationSchemeIndex];
        }
    }
    private int m_XboxSchemeIndex = -1;
    public InputControlScheme XboxScheme
    {
        get
        {
            if (m_XboxSchemeIndex == -1) m_XboxSchemeIndex = asset.FindControlSchemeIndex("Xbox");
            return asset.controlSchemes[m_XboxSchemeIndex];
        }
    }
    private int m_SwitchSchemeIndex = -1;
    public InputControlScheme SwitchScheme
    {
        get
        {
            if (m_SwitchSchemeIndex == -1) m_SwitchSchemeIndex = asset.FindControlSchemeIndex("Switch ");
            return asset.controlSchemes[m_SwitchSchemeIndex];
        }
    }
    public interface IPlayerTaxiActions
    {
        void OnAccelerate(InputAction.CallbackContext context);
        void OnReverse(InputAction.CallbackContext context);
        void OnDrift(InputAction.CallbackContext context);
        void OnTurning(InputAction.CallbackContext context);
        void OnBoost(InputAction.CallbackContext context);
        void OnJump(InputAction.CallbackContext context);
    }
}
