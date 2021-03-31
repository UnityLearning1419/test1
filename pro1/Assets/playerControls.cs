// GENERATED AUTOMATICALLY FROM 'Assets/playerControls.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @PlayerControls : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerControls()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""playerControls"",
    ""maps"": [
        {
            ""name"": ""player"",
            ""id"": ""44e65843-e3fe-4d03-aa70-cd6c858e4452"",
            ""actions"": [
                {
                    ""name"": ""forward"",
                    ""type"": ""Value"",
                    ""id"": ""ee282075-5880-4630-bb1f-61978b43edd2"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""enable"",
                    ""type"": ""Value"",
                    ""id"": ""7b0795de-14dc-42a8-92aa-2cc590048da9"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""disable"",
                    ""type"": ""Value"",
                    ""id"": ""ecde4bd8-8208-49db-96eb-b4ce978a8819"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""back_off"",
                    ""type"": ""Value"",
                    ""id"": ""ae13b536-09f1-4ae3-bfe6-bf3916a5e774"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""break"",
                    ""type"": ""Value"",
                    ""id"": ""f90ccfb4-7876-40d7-b634-05a697feeb8c"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""turnleft"",
                    ""type"": ""Value"",
                    ""id"": ""4f88685f-5679-4b88-b74a-e369a1deebdc"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""turnright"",
                    ""type"": ""Value"",
                    ""id"": ""123e7d22-4f57-49b5-9d86-e1cd7978f4e3"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""move"",
                    ""type"": ""Button"",
                    ""id"": ""fdb74f21-a12b-4fd9-a625-823c440b2c67"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""horizontal"",
                    ""type"": ""Value"",
                    ""id"": ""b1a8f4f9-5f4b-4776-a6cd-a0d26e8081bc"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""camera"",
                    ""type"": ""Value"",
                    ""id"": ""1f324502-8125-496e-9beb-253265051c42"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": ""InvertVector2(invertX=false)"",
                    ""interactions"": """"
                },
                {
                    ""name"": ""switchView"",
                    ""type"": ""Button"",
                    ""id"": ""5dfecbd8-bcfe-457f-8b67-23ecd8048493"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": ""InvertVector2(invertX=false)"",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""5e5f065a-48cb-44e6-8a62-67f70def461c"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""forward"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""379eb144-8fd4-4f70-91fc-bd268baee058"",
                    ""path"": ""<XInputController>/rightTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""forward"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""a567c355-93d0-4c6a-8492-76b3b0040b46"",
                    ""path"": ""<Joystick>/stick/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""forward"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""cbbb93a4-a3d3-4f11-9b11-3b96fb1bae68"",
                    ""path"": ""<Keyboard>/y"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""enable"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""cfba1947-aab2-4e91-905a-55c91374be10"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""back_off"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""ebcd48ba-c6b9-45ad-b826-8b206ca4d224"",
                    ""path"": ""<XInputController>/leftTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""back_off"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""80d3f2f2-1609-4a68-b4d3-5a09d50d2f9f"",
                    ""path"": ""<HID::PC Game Controller       >/button11"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""back_off"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""8f297066-1220-4050-8f98-02d73b3bd1fe"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""break"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""c9d91c9e-3d4f-4e17-b40a-74161a08f349"",
                    ""path"": ""<XInputController>/buttonEast"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""break"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""750d2085-0628-4054-9d54-6736de595b13"",
                    ""path"": ""<Joystick>/stick/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""break"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""e9027717-9b50-4dcf-afb7-ac95cd008058"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""turnleft"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""b1d97196-85a3-4ffa-b3fe-3804571f8b8b"",
                    ""path"": ""<XInputController>/leftStick/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""turnleft"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""0829fccf-cf31-4682-be98-215da8f6e8cd"",
                    ""path"": ""<Joystick>/stick/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""turnleft"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""dff32f96-1b29-4a51-83ee-59985edf8111"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""turnright"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""0cadd587-bebd-41e3-82fd-759af8102b3e"",
                    ""path"": ""<XInputController>/leftStick/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""turnright"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""d8795737-10de-4d60-b531-0f7f932df423"",
                    ""path"": ""<Joystick>/stick/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""turnright"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""verticality"",
                    ""id"": ""4454b6c0-e65d-4846-817d-1153c367f1af"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""move"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""8e9be6ad-dac5-4d85-b651-aa551cae4073"",
                    ""path"": ""<XInputController>/rightTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""642234fe-340b-4e36-b3b5-018e4437aebc"",
                    ""path"": ""<XInputController>/leftTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""ws"",
                    ""id"": ""d84300c1-2542-4ee6-9f1d-7ffe427d2971"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""move"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""f2a911a9-0178-41e3-bd0f-f5e98be33c89"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""1ee907c1-f916-465c-9df2-e044e26b3a0d"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""driverControler"",
                    ""id"": ""51bea5a7-f037-43d8-9fde-f85e3bd4b336"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""move"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""fdb43227-9e08-44a4-a681-235115d5783f"",
                    ""path"": ""<Joystick>/stick/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""f5764703-1d86-45e0-9f62-0f65047c3f8c"",
                    ""path"": ""<HID::PC Game Controller       >/stick/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""30ecf9b2-1220-4e3c-85d5-b0b82ef7a75c"",
                    ""path"": ""<XInputController>/leftStick/x"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""horizontal"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""ad"",
                    ""id"": ""1b3bddbf-b7bd-4081-9cd3-71c26f21f884"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""horizontal"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""00861e75-52dc-4a48-8137-2e080b7eeddc"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""horizontal"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""21ba9bd8-4aaa-4dc9-a45d-d73f3843015d"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""horizontal"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""b93f0dc8-ee0a-4b70-bc10-0a2085a96a0c"",
                    ""path"": ""<Joystick>/stick/x"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""horizontal"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""b84299ec-c4e3-4b1f-9a2b-4a84f10c37e7"",
                    ""path"": ""<Keyboard>/n"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""disable"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""8050b746-b373-45b9-bad4-2e4eb9f0b3af"",
                    ""path"": ""<XInputController>/rightStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""camera"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""906c7c25-afbf-45eb-8c7d-0f3f4007c63a"",
                    ""path"": ""<Mouse>/delta"",
                    ""interactions"": """",
                    ""processors"": ""NormalizeVector2"",
                    ""groups"": """",
                    ""action"": ""camera"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""2e65aa30-5b97-40ea-9a2d-b5f17c2332ba"",
                    ""path"": ""<Keyboard>/v"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""switchView"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""2d32d103-1141-4c71-aabf-e64807a164be"",
                    ""path"": ""<XInputController>/start"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""switchView"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""304ba761-817b-49ff-b1a9-7ba6cbd61588"",
                    ""path"": ""<Joystick>/trigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""switchView"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // player
        m_player = asset.FindActionMap("player", throwIfNotFound: true);
        m_player_forward = m_player.FindAction("forward", throwIfNotFound: true);
        m_player_enable = m_player.FindAction("enable", throwIfNotFound: true);
        m_player_disable = m_player.FindAction("disable", throwIfNotFound: true);
        m_player_back_off = m_player.FindAction("back_off", throwIfNotFound: true);
        m_player_break = m_player.FindAction("break", throwIfNotFound: true);
        m_player_turnleft = m_player.FindAction("turnleft", throwIfNotFound: true);
        m_player_turnright = m_player.FindAction("turnright", throwIfNotFound: true);
        m_player_move = m_player.FindAction("move", throwIfNotFound: true);
        m_player_horizontal = m_player.FindAction("horizontal", throwIfNotFound: true);
        m_player_camera = m_player.FindAction("camera", throwIfNotFound: true);
        m_player_switchView = m_player.FindAction("switchView", throwIfNotFound: true);
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

    // player
    private readonly InputActionMap m_player;
    private IPlayerActions m_PlayerActionsCallbackInterface;
    private readonly InputAction m_player_forward;
    private readonly InputAction m_player_enable;
    private readonly InputAction m_player_disable;
    private readonly InputAction m_player_back_off;
    private readonly InputAction m_player_break;
    private readonly InputAction m_player_turnleft;
    private readonly InputAction m_player_turnright;
    private readonly InputAction m_player_move;
    private readonly InputAction m_player_horizontal;
    private readonly InputAction m_player_camera;
    private readonly InputAction m_player_switchView;
    public struct PlayerActions
    {
        private @PlayerControls m_Wrapper;
        public PlayerActions(@PlayerControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @forward => m_Wrapper.m_player_forward;
        public InputAction @enable => m_Wrapper.m_player_enable;
        public InputAction @disable => m_Wrapper.m_player_disable;
        public InputAction @back_off => m_Wrapper.m_player_back_off;
        public InputAction @break => m_Wrapper.m_player_break;
        public InputAction @turnleft => m_Wrapper.m_player_turnleft;
        public InputAction @turnright => m_Wrapper.m_player_turnright;
        public InputAction @move => m_Wrapper.m_player_move;
        public InputAction @horizontal => m_Wrapper.m_player_horizontal;
        public InputAction @camera => m_Wrapper.m_player_camera;
        public InputAction @switchView => m_Wrapper.m_player_switchView;
        public InputActionMap Get() { return m_Wrapper.m_player; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlayerActions set) { return set.Get(); }
        public void SetCallbacks(IPlayerActions instance)
        {
            if (m_Wrapper.m_PlayerActionsCallbackInterface != null)
            {
                @forward.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnForward;
                @forward.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnForward;
                @forward.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnForward;
                @enable.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnEnable;
                @enable.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnEnable;
                @enable.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnEnable;
                @disable.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnDisable;
                @disable.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnDisable;
                @disable.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnDisable;
                @back_off.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnBack_off;
                @back_off.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnBack_off;
                @back_off.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnBack_off;
                @break.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnBreak;
                @break.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnBreak;
                @break.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnBreak;
                @turnleft.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnTurnleft;
                @turnleft.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnTurnleft;
                @turnleft.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnTurnleft;
                @turnright.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnTurnright;
                @turnright.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnTurnright;
                @turnright.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnTurnright;
                @move.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMove;
                @move.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMove;
                @move.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMove;
                @horizontal.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnHorizontal;
                @horizontal.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnHorizontal;
                @horizontal.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnHorizontal;
                @camera.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnCamera;
                @camera.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnCamera;
                @camera.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnCamera;
                @switchView.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnSwitchView;
                @switchView.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnSwitchView;
                @switchView.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnSwitchView;
            }
            m_Wrapper.m_PlayerActionsCallbackInterface = instance;
            if (instance != null)
            {
                @forward.started += instance.OnForward;
                @forward.performed += instance.OnForward;
                @forward.canceled += instance.OnForward;
                @enable.started += instance.OnEnable;
                @enable.performed += instance.OnEnable;
                @enable.canceled += instance.OnEnable;
                @disable.started += instance.OnDisable;
                @disable.performed += instance.OnDisable;
                @disable.canceled += instance.OnDisable;
                @back_off.started += instance.OnBack_off;
                @back_off.performed += instance.OnBack_off;
                @back_off.canceled += instance.OnBack_off;
                @break.started += instance.OnBreak;
                @break.performed += instance.OnBreak;
                @break.canceled += instance.OnBreak;
                @turnleft.started += instance.OnTurnleft;
                @turnleft.performed += instance.OnTurnleft;
                @turnleft.canceled += instance.OnTurnleft;
                @turnright.started += instance.OnTurnright;
                @turnright.performed += instance.OnTurnright;
                @turnright.canceled += instance.OnTurnright;
                @move.started += instance.OnMove;
                @move.performed += instance.OnMove;
                @move.canceled += instance.OnMove;
                @horizontal.started += instance.OnHorizontal;
                @horizontal.performed += instance.OnHorizontal;
                @horizontal.canceled += instance.OnHorizontal;
                @camera.started += instance.OnCamera;
                @camera.performed += instance.OnCamera;
                @camera.canceled += instance.OnCamera;
                @switchView.started += instance.OnSwitchView;
                @switchView.performed += instance.OnSwitchView;
                @switchView.canceled += instance.OnSwitchView;
            }
        }
    }
    public PlayerActions @player => new PlayerActions(this);
    public interface IPlayerActions
    {
        void OnForward(InputAction.CallbackContext context);
        void OnEnable(InputAction.CallbackContext context);
        void OnDisable(InputAction.CallbackContext context);
        void OnBack_off(InputAction.CallbackContext context);
        void OnBreak(InputAction.CallbackContext context);
        void OnTurnleft(InputAction.CallbackContext context);
        void OnTurnright(InputAction.CallbackContext context);
        void OnMove(InputAction.CallbackContext context);
        void OnHorizontal(InputAction.CallbackContext context);
        void OnCamera(InputAction.CallbackContext context);
        void OnSwitchView(InputAction.CallbackContext context);
    }
}
