// GENERATED AUTOMATICALLY FROM 'Assets/Scripts/Interaction/InputSystem/InputSystemAsset.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @InputSystemAsset : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @InputSystemAsset()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""InputSystemAsset"",
    ""maps"": [
        {
            ""name"": ""CameraMovement"",
            ""id"": ""92e2da28-f756-49ca-b5c3-df94661e8838"",
            ""actions"": [
                {
                    ""name"": ""Forward/Backward"",
                    ""type"": ""Value"",
                    ""id"": ""19adcab2-cea0-462b-891d-ca39c5901845"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Left/Right"",
                    ""type"": ""Value"",
                    ""id"": ""e2befcce-1cad-4942-8065-d9d593bf0f0f"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Up/Down"",
                    ""type"": ""Value"",
                    ""id"": ""759fe602-bd95-42fc-8824-dc15d88d66e9"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Fast"",
                    ""type"": ""Button"",
                    ""id"": ""15b4e1e9-5d26-46a3-a627-6032e0b07275"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Focus"",
                    ""type"": ""Button"",
                    ""id"": ""2a63dfac-bca3-4b2a-94a0-116b4d50d553"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""W/S"",
                    ""id"": ""8b436b4c-9e94-486d-87e4-47a90e21cf39"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Forward/Backward"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""486969cb-d230-40e7-a322-4db267cac646"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Forward/Backward"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""e1bf2be1-3cca-4024-b2ab-814548d8fae3"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Forward/Backward"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Arrows"",
                    ""id"": ""e78f1a38-4441-494c-a89a-ce0690c4c4f8"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Forward/Backward"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""0d2c8ef3-3402-4df5-b1c4-042af0e1576f"",
                    ""path"": ""<Keyboard>/downArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Forward/Backward"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""2f8acf47-45e9-4ab6-bd5e-c23a18f312f6"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Forward/Backward"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""A/D"",
                    ""id"": ""ccb012ce-3fbd-4f1a-a0bd-26d1ecd66c10"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Left/Right"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""34b2fc34-e64d-4347-8a8d-006fd08eeb29"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Left/Right"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""3d599cc1-ba94-4e71-859a-9e5a955ab5dd"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Left/Right"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Arrows"",
                    ""id"": ""e262ab4d-c8e3-4757-a38e-e50b95167039"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Left/Right"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""e7cfecd5-512f-4570-bc18-5c308c03e966"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Left/Right"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""1b78b34c-13f5-4d56-a632-1f404fc8fd76"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Left/Right"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Q/E"",
                    ""id"": ""8b8b5388-29ea-46b5-9680-ce5570b7e819"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Up/Down"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""7dbcb811-4c17-48cf-abb8-ea5e659c91e2"",
                    ""path"": ""<Keyboard>/q"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Up/Down"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""2cfb6e79-9ad2-4ad2-bde5-4679b639aa48"",
                    ""path"": ""<Keyboard>/e"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Up/Down"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Ctrl/Space"",
                    ""id"": ""3bd206f1-ca59-44b8-a48c-73661da7a7c6"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Up/Down"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""00caa2a9-a660-4fc7-91a0-2c8ad17b8d9b"",
                    ""path"": ""<Keyboard>/ctrl"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Up/Down"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""948dbeab-174a-4d7f-af3c-77cc2c5a22b1"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Up/Down"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""cf61f9c6-0c54-46bc-82d7-7f86b393b144"",
                    ""path"": ""<Keyboard>/shift"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Fast"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""74576c47-1b8a-4b60-9c3d-197114866c9c"",
                    ""path"": ""<Keyboard>/f"",
                    ""interactions"": ""Press(behavior=1)"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Focus"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""Hotkeys"",
            ""id"": ""8f93eafc-8791-488e-9f5a-ace7e41aa109"",
            ""actions"": [
                {
                    ""name"": ""Undo"",
                    ""type"": ""Button"",
                    ""id"": ""09891e6f-29c4-4c3d-a79b-7c3f2231788e"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Redo"",
                    ""type"": ""Button"",
                    ""id"": ""88a78b3a-dfb4-4fdf-a322-8301ba9f34ee"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""Button With One Modifier"",
                    ""id"": ""70fc897c-4a81-42b7-a3b7-dba44a1789fc"",
                    ""path"": ""ButtonWithOneModifier"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Undo"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""Modifier"",
                    ""id"": ""b28e1e33-7ec3-4373-b02e-13cc7dcb7348"",
                    ""path"": ""<Keyboard>/ctrl"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Undo"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Button"",
                    ""id"": ""c33e4664-b0b8-4a11-a2f0-879b647cd735"",
                    ""path"": ""<Keyboard>/#(z)"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Undo"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Button With One Modifier"",
                    ""id"": ""2e13c153-9bff-4303-a9d6-6f5f571f126f"",
                    ""path"": ""ButtonWithOneModifier"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Redo"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""modifier"",
                    ""id"": ""bd677f15-68c5-42e1-a2e2-fb56f45ffe2f"",
                    ""path"": ""<Keyboard>/ctrl"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Redo"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""button"",
                    ""id"": ""40a517f0-5658-40e7-aa7a-c10a3dc2ffbb"",
                    ""path"": ""<Keyboard>/#(y)"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Redo"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                }
            ]
        },
        {
            ""name"": ""Modifier"",
            ""id"": ""b9ba5ee0-bed2-42d8-8e4a-ea4128cef61c"",
            ""actions"": [
                {
                    ""name"": ""Shift"",
                    ""type"": ""Button"",
                    ""id"": ""63f7c2e6-f5ab-46f4-a6cd-da2db9a93de1"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Ctrl"",
                    ""type"": ""Button"",
                    ""id"": ""07cd1e4b-e5e8-4f6a-a545-0c04dd83ef88"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Alt"",
                    ""type"": ""Button"",
                    ""id"": ""81ec1c81-b16a-4f90-827b-e7eae4f8d02b"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""3b7a9abd-daf7-4e91-abe1-36381ed07f34"",
                    ""path"": ""<Keyboard>/shift"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Shift"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""c8626432-5e74-4fca-9038-824c8f7b1979"",
                    ""path"": ""<Keyboard>/ctrl"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Ctrl"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""3641cd79-c088-4475-9550-940a39fb1862"",
                    ""path"": ""<Keyboard>/alt"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Alt"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // CameraMovement
        m_CameraMovement = asset.FindActionMap("CameraMovement", throwIfNotFound: true);
        m_CameraMovement_ForwardBackward = m_CameraMovement.FindAction("Forward/Backward", throwIfNotFound: true);
        m_CameraMovement_LeftRight = m_CameraMovement.FindAction("Left/Right", throwIfNotFound: true);
        m_CameraMovement_UpDown = m_CameraMovement.FindAction("Up/Down", throwIfNotFound: true);
        m_CameraMovement_Fast = m_CameraMovement.FindAction("Fast", throwIfNotFound: true);
        m_CameraMovement_Focus = m_CameraMovement.FindAction("Focus", throwIfNotFound: true);
        // Hotkeys
        m_Hotkeys = asset.FindActionMap("Hotkeys", throwIfNotFound: true);
        m_Hotkeys_Undo = m_Hotkeys.FindAction("Undo", throwIfNotFound: true);
        m_Hotkeys_Redo = m_Hotkeys.FindAction("Redo", throwIfNotFound: true);
        // Modifier
        m_Modifier = asset.FindActionMap("Modifier", throwIfNotFound: true);
        m_Modifier_Shift = m_Modifier.FindAction("Shift", throwIfNotFound: true);
        m_Modifier_Ctrl = m_Modifier.FindAction("Ctrl", throwIfNotFound: true);
        m_Modifier_Alt = m_Modifier.FindAction("Alt", throwIfNotFound: true);
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

    // CameraMovement
    private readonly InputActionMap m_CameraMovement;
    private ICameraMovementActions m_CameraMovementActionsCallbackInterface;
    private readonly InputAction m_CameraMovement_ForwardBackward;
    private readonly InputAction m_CameraMovement_LeftRight;
    private readonly InputAction m_CameraMovement_UpDown;
    private readonly InputAction m_CameraMovement_Fast;
    private readonly InputAction m_CameraMovement_Focus;
    public struct CameraMovementActions
    {
        private @InputSystemAsset m_Wrapper;
        public CameraMovementActions(@InputSystemAsset wrapper) { m_Wrapper = wrapper; }
        public InputAction @ForwardBackward => m_Wrapper.m_CameraMovement_ForwardBackward;
        public InputAction @LeftRight => m_Wrapper.m_CameraMovement_LeftRight;
        public InputAction @UpDown => m_Wrapper.m_CameraMovement_UpDown;
        public InputAction @Fast => m_Wrapper.m_CameraMovement_Fast;
        public InputAction @Focus => m_Wrapper.m_CameraMovement_Focus;
        public InputActionMap Get() { return m_Wrapper.m_CameraMovement; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(CameraMovementActions set) { return set.Get(); }
        public void SetCallbacks(ICameraMovementActions instance)
        {
            if (m_Wrapper.m_CameraMovementActionsCallbackInterface != null)
            {
                @ForwardBackward.started -= m_Wrapper.m_CameraMovementActionsCallbackInterface.OnForwardBackward;
                @ForwardBackward.performed -= m_Wrapper.m_CameraMovementActionsCallbackInterface.OnForwardBackward;
                @ForwardBackward.canceled -= m_Wrapper.m_CameraMovementActionsCallbackInterface.OnForwardBackward;
                @LeftRight.started -= m_Wrapper.m_CameraMovementActionsCallbackInterface.OnLeftRight;
                @LeftRight.performed -= m_Wrapper.m_CameraMovementActionsCallbackInterface.OnLeftRight;
                @LeftRight.canceled -= m_Wrapper.m_CameraMovementActionsCallbackInterface.OnLeftRight;
                @UpDown.started -= m_Wrapper.m_CameraMovementActionsCallbackInterface.OnUpDown;
                @UpDown.performed -= m_Wrapper.m_CameraMovementActionsCallbackInterface.OnUpDown;
                @UpDown.canceled -= m_Wrapper.m_CameraMovementActionsCallbackInterface.OnUpDown;
                @Fast.started -= m_Wrapper.m_CameraMovementActionsCallbackInterface.OnFast;
                @Fast.performed -= m_Wrapper.m_CameraMovementActionsCallbackInterface.OnFast;
                @Fast.canceled -= m_Wrapper.m_CameraMovementActionsCallbackInterface.OnFast;
                @Focus.started -= m_Wrapper.m_CameraMovementActionsCallbackInterface.OnFocus;
                @Focus.performed -= m_Wrapper.m_CameraMovementActionsCallbackInterface.OnFocus;
                @Focus.canceled -= m_Wrapper.m_CameraMovementActionsCallbackInterface.OnFocus;
            }
            m_Wrapper.m_CameraMovementActionsCallbackInterface = instance;
            if (instance != null)
            {
                @ForwardBackward.started += instance.OnForwardBackward;
                @ForwardBackward.performed += instance.OnForwardBackward;
                @ForwardBackward.canceled += instance.OnForwardBackward;
                @LeftRight.started += instance.OnLeftRight;
                @LeftRight.performed += instance.OnLeftRight;
                @LeftRight.canceled += instance.OnLeftRight;
                @UpDown.started += instance.OnUpDown;
                @UpDown.performed += instance.OnUpDown;
                @UpDown.canceled += instance.OnUpDown;
                @Fast.started += instance.OnFast;
                @Fast.performed += instance.OnFast;
                @Fast.canceled += instance.OnFast;
                @Focus.started += instance.OnFocus;
                @Focus.performed += instance.OnFocus;
                @Focus.canceled += instance.OnFocus;
            }
        }
    }
    public CameraMovementActions @CameraMovement => new CameraMovementActions(this);

    // Hotkeys
    private readonly InputActionMap m_Hotkeys;
    private IHotkeysActions m_HotkeysActionsCallbackInterface;
    private readonly InputAction m_Hotkeys_Undo;
    private readonly InputAction m_Hotkeys_Redo;
    public struct HotkeysActions
    {
        private @InputSystemAsset m_Wrapper;
        public HotkeysActions(@InputSystemAsset wrapper) { m_Wrapper = wrapper; }
        public InputAction @Undo => m_Wrapper.m_Hotkeys_Undo;
        public InputAction @Redo => m_Wrapper.m_Hotkeys_Redo;
        public InputActionMap Get() { return m_Wrapper.m_Hotkeys; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(HotkeysActions set) { return set.Get(); }
        public void SetCallbacks(IHotkeysActions instance)
        {
            if (m_Wrapper.m_HotkeysActionsCallbackInterface != null)
            {
                @Undo.started -= m_Wrapper.m_HotkeysActionsCallbackInterface.OnUndo;
                @Undo.performed -= m_Wrapper.m_HotkeysActionsCallbackInterface.OnUndo;
                @Undo.canceled -= m_Wrapper.m_HotkeysActionsCallbackInterface.OnUndo;
                @Redo.started -= m_Wrapper.m_HotkeysActionsCallbackInterface.OnRedo;
                @Redo.performed -= m_Wrapper.m_HotkeysActionsCallbackInterface.OnRedo;
                @Redo.canceled -= m_Wrapper.m_HotkeysActionsCallbackInterface.OnRedo;
            }
            m_Wrapper.m_HotkeysActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Undo.started += instance.OnUndo;
                @Undo.performed += instance.OnUndo;
                @Undo.canceled += instance.OnUndo;
                @Redo.started += instance.OnRedo;
                @Redo.performed += instance.OnRedo;
                @Redo.canceled += instance.OnRedo;
            }
        }
    }
    public HotkeysActions @Hotkeys => new HotkeysActions(this);

    // Modifier
    private readonly InputActionMap m_Modifier;
    private IModifierActions m_ModifierActionsCallbackInterface;
    private readonly InputAction m_Modifier_Shift;
    private readonly InputAction m_Modifier_Ctrl;
    private readonly InputAction m_Modifier_Alt;
    public struct ModifierActions
    {
        private @InputSystemAsset m_Wrapper;
        public ModifierActions(@InputSystemAsset wrapper) { m_Wrapper = wrapper; }
        public InputAction @Shift => m_Wrapper.m_Modifier_Shift;
        public InputAction @Ctrl => m_Wrapper.m_Modifier_Ctrl;
        public InputAction @Alt => m_Wrapper.m_Modifier_Alt;
        public InputActionMap Get() { return m_Wrapper.m_Modifier; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(ModifierActions set) { return set.Get(); }
        public void SetCallbacks(IModifierActions instance)
        {
            if (m_Wrapper.m_ModifierActionsCallbackInterface != null)
            {
                @Shift.started -= m_Wrapper.m_ModifierActionsCallbackInterface.OnShift;
                @Shift.performed -= m_Wrapper.m_ModifierActionsCallbackInterface.OnShift;
                @Shift.canceled -= m_Wrapper.m_ModifierActionsCallbackInterface.OnShift;
                @Ctrl.started -= m_Wrapper.m_ModifierActionsCallbackInterface.OnCtrl;
                @Ctrl.performed -= m_Wrapper.m_ModifierActionsCallbackInterface.OnCtrl;
                @Ctrl.canceled -= m_Wrapper.m_ModifierActionsCallbackInterface.OnCtrl;
                @Alt.started -= m_Wrapper.m_ModifierActionsCallbackInterface.OnAlt;
                @Alt.performed -= m_Wrapper.m_ModifierActionsCallbackInterface.OnAlt;
                @Alt.canceled -= m_Wrapper.m_ModifierActionsCallbackInterface.OnAlt;
            }
            m_Wrapper.m_ModifierActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Shift.started += instance.OnShift;
                @Shift.performed += instance.OnShift;
                @Shift.canceled += instance.OnShift;
                @Ctrl.started += instance.OnCtrl;
                @Ctrl.performed += instance.OnCtrl;
                @Ctrl.canceled += instance.OnCtrl;
                @Alt.started += instance.OnAlt;
                @Alt.performed += instance.OnAlt;
                @Alt.canceled += instance.OnAlt;
            }
        }
    }
    public ModifierActions @Modifier => new ModifierActions(this);
    public interface ICameraMovementActions
    {
        void OnForwardBackward(InputAction.CallbackContext context);
        void OnLeftRight(InputAction.CallbackContext context);
        void OnUpDown(InputAction.CallbackContext context);
        void OnFast(InputAction.CallbackContext context);
        void OnFocus(InputAction.CallbackContext context);
    }
    public interface IHotkeysActions
    {
        void OnUndo(InputAction.CallbackContext context);
        void OnRedo(InputAction.CallbackContext context);
    }
    public interface IModifierActions
    {
        void OnShift(InputAction.CallbackContext context);
        void OnCtrl(InputAction.CallbackContext context);
        void OnAlt(InputAction.CallbackContext context);
    }
}
