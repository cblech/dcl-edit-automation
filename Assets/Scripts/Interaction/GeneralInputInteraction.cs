using Assets.Scripts.EditorState;
using UnityEngine;
using UnityEngine.InputSystem;
using Cursor = UnityEngine.Cursor;

namespace Assets.Scripts.Interaction
{
    public class GeneralInputInteraction : MonoBehaviour
    {
        private InputSystemAsset _inputSystemAsset;

        


        void Awake()
        {
            _inputSystemAsset = new InputSystemAsset();
            _inputSystemAsset.CameraMovement.Enable();
            _inputSystemAsset.Modifier.Enable();
        }

        // Update is called once per frame
        void Update()
        {
            InputHelper.UpdateMouseDowns();

            switch (EditorStates.CurrentInputState.InState)
            {
                case InputState.InStateType.NoInput:
                    UpdateNoInput();
                    break;
                case InputState.InStateType.WasdMovement:
                    UpdateWasdMovement();
                    break;
                case InputState.InStateType.MouseZoom:
                    UpdateMouseZoom();
                    break;
                case InputState.InStateType.RotateAroundPoint:
                    UpdateRotateAroundPoint();
                    break;
                case InputState.InStateType.SlideSideways:
                    UpdateSlideSideways();
                    break;

                case InputState.InStateType.HoldingGizmoTool:
                default:
                    EditorStates.CurrentInputState.InState = InputState.InStateType.NoInput;
                    break;
            }
        }


        private void UpdateNoInput()
        {
            var pressingAlt = _inputSystemAsset.Modifier.Alt.IsPressed();
            var pressingControl = _inputSystemAsset.Modifier.Ctrl.IsPressed();
            var pressingShift = _inputSystemAsset.Modifier.Shift.IsPressed();

            var isSprinting = _inputSystemAsset.CameraMovement.Fast.IsPressed();

            // Get the ray from the camera, where the mouse currently is
            var mouseRay = EditorStates.CurrentCameraState.MainCamera.ViewportPointToRay(EditorStates.CurrentCameraState.MainCamera.ScreenToViewportPoint(InputHelper.GetMousePosition()));

            // Figure out, if the mouse is over the Game window
            var mousePosition = InputHelper.GetMousePosition();
            var isMouseOverGameWindow =
                !(0 > mousePosition.x ||
                  0 > mousePosition.y ||
                  Screen.width < mousePosition.x ||
                  Screen.height < mousePosition.y);

            // Figure out, if the mouse is over the 3D viewport (not hovering over any UI)
            var isMouseIn3DView = /*!EventSystem.current.IsPointerOverGameObject() &&*/ isMouseOverGameWindow;

            // The position the mouse currently points to in the 3D viewport
            Vector3? mousePositionIn3DView = null;

            // Do the following block only, if the mouse is over the 3D view
            if (isMouseIn3DView)
            {
                // First check, if mouse is hovering over a Gizmo
                if (Physics.Raycast(mouseRay, out RaycastHit hitInfoGizmos, 10000, LayerMask.GetMask("Gizmos")))
                {
                    mousePositionIn3DView = hitInfoGizmos.point;
                    EditorStates.CurrentInterface3DState.CurrentlyHoveredObject = hitInfoGizmos.transform.gameObject;
                }
                // Secondly check, if mouse is hovering over a Entity
                else if (Physics.Raycast(mouseRay, out RaycastHit hitInfoEntity, 10000, LayerMask.GetMask("Entity Click"))) // mouse click layer
                {
                    mousePositionIn3DView = hitInfoEntity.point;
                    EditorStates.CurrentInterface3DState.CurrentlyHoveredObject = hitInfoEntity.transform.gameObject;
                }
                else
                {
                    EditorStates.CurrentInterface3DState.CurrentlyHoveredObject = null;
                }
            }
            else
            {
                EditorStates.CurrentInterface3DState.CurrentlyHoveredObject = null;
            }
            

            // If the mouse is not over any Gizmo or Entity, then get the mouse position on the Ground plane
            if (mousePositionIn3DView == null)
            {
                var groundPlane = new Plane(Vector3.up, Vector3.zero);
                groundPlane.Raycast(mouseRay, out float enter);
                if (enter > 2000 || enter < 0)
                {
                    mousePositionIn3DView = mouseRay.GetPoint(10);
                }
                else
                {
                    mousePositionIn3DView = mouseRay.GetPoint(enter);
                }
            }

            // When pressing(down) Left mouse button, select the hovered entity
            if (InputHelper.IsLeftMouseButtonDown() && !pressingAlt && isMouseIn3DView)
            {
                // select entity
                var selectInteraction = EditorStates.CurrentInterface3DState.CurrentlyHoveredObject?
                    .GetComponentInParent<EntitySelectInteraction>();

                if (selectInteraction != null)
                {
                    if (pressingControl)
                    {
                        selectInteraction.SelectAdditional(); // When pressing control, add entity to selection
                    }
                    else
                    {
                        selectInteraction.SelectSingle(); // When not pressing control, set entity as single selection
                    }
                }
            }
            
            // When pressing Right mouse button (without alt), switch to Camera WASD moving state
            if (InputHelper.IsRightMouseButtonPressed() && !pressingAlt && isMouseIn3DView)
            {
                EditorStates.CurrentInputState.InState = InputState.InStateType.WasdMovement;
                InputHelper.HideMouse();
            }

            // When pressing alt and Right mouse button, switch to Mouse Zooming state
            if (InputHelper.IsRightMouseButtonPressed() && pressingAlt && isMouseIn3DView)
            {
                EditorStates.CurrentInputState.InState = InputState.InStateType.MouseZoom;
                InputHelper.HideMouse();
            }

            // When pressing ald and Left mouse button, switch to Rotate around point state
            if (InputHelper.IsLeftMouseButtonPressed() && pressingAlt && isMouseIn3DView)
            {
                EditorStates.CurrentInputState.RotateCameraAroundPoint = mousePositionIn3DView;
                EditorStates.CurrentInputState.InState = InputState.InStateType.RotateAroundPoint;
                InputHelper.HideMouse();
            }

            // When pressing Middle mouse button, switch to "Camera slide moving state"
            if (InputHelper.IsMiddleMouseButtonPressed() && isMouseIn3DView)
            {
                EditorStates.CurrentInputState.InState = InputState.InStateType.SlideSideways;
                InputHelper.HideMouse();
            }

            // When scrolling Mouse wheel, zoom in or out
            if (isMouseIn3DView)
            {
                var mouseScroll = Mouse.current.scroll.ReadValue().y / 1000;

                if (Mathf.Abs(mouseScroll) > 0)
                {
                    EditorStates.CurrentCameraState.MoveStep(new Vector3(0, 0, mouseScroll), isSprinting);
                }
            }
        }

        private void UpdateWasdMovement()
        {
            var isSprinting = _inputSystemAsset.CameraMovement.Fast.IsPressed();

            // Rotate camera with mouse movement
            EditorStates.CurrentCameraState.RotateStep(InputHelper.GetMouseMovement());

            // Move camera with WASD keys. To go faster, hold shift
            EditorStates.CurrentCameraState.MoveContinuously(
                new Vector3(
                    _inputSystemAsset.CameraMovement.LeftRight.ReadValue<float>(),
                    _inputSystemAsset.CameraMovement.UpDown.ReadValue<float>(),
                    _inputSystemAsset.CameraMovement.ForwardBackward.ReadValue<float>()),
                    isSprinting);

            // When releasing Right mouse button, switch to "No input state"
            if (!InputHelper.IsRightMouseButtonPressed())
            {
                EditorStates.CurrentInputState.InState = InputState.InStateType.NoInput;
                InputHelper.ShowMouse();
            }
        }

        private void UpdateMouseZoom()
        {
            var isSprinting = _inputSystemAsset.CameraMovement.Fast.IsPressed();
            var mouseMovement = InputHelper.GetMouseMovement();
            var targetMovement = mouseMovement.x + mouseMovement.y;

            EditorStates.CurrentCameraState.MoveStep(Vector3.forward * targetMovement * 0.03f, isSprinting);


            // When releasing Right mouse button, switch to "No input state"
            if (!InputHelper.IsRightMouseButtonPressed())
            {
                EditorStates.CurrentInputState.InState = InputState.InStateType.NoInput;
                InputHelper.ShowMouse();
            }
        }

        private void UpdateRotateAroundPoint()
        {
            // Rotate camera around point with mouse movement
            if (EditorStates.CurrentInputState.RotateCameraAroundPoint != null)
                EditorStates.CurrentCameraState.RotateAroundPointStep(
                    EditorStates.CurrentInputState.RotateCameraAroundPoint.Value,
                    InputHelper.GetMouseMovement());

            // When releasing Left mouse button, switch to "No input state"
            if (!InputHelper.IsLeftMouseButtonPressed())
            {
                EditorStates.CurrentInputState.InState = InputState.InStateType.NoInput;
                InputHelper.ShowMouse();
            }
        }

        private void UpdateSlideSideways()
        {
            var isSprinting = _inputSystemAsset.CameraMovement.Fast.IsPressed();
            // Move camera sideways with mouse movement
            var mouseMovement = InputHelper.GetMouseMovement();
            var targetMovement = new Vector3(mouseMovement.x, mouseMovement.y, 0);
            EditorStates.CurrentCameraState.MoveStep(targetMovement * -0.03f, isSprinting);

            // When releasing Middle mouse button, switch to "No input state"
            if (!InputHelper.IsMiddleMouseButtonPressed())
            {
                EditorStates.CurrentInputState.InState = InputState.InStateType.NoInput;
                InputHelper.ShowMouse();
            }
        }




        private static class InputHelper
        {
            private static Vector2 _mousePositionWhenHiding;

            private static bool _wasLeftPressed;
            private static bool _wasMiddlePressed;
            private static bool _wasRightPressed;

            private static bool _isLeftDown;
            private static bool _isMiddleDown;
            private static bool _isRightDown;

            public static void UpdateMouseDowns()
            {
                var leftPressed = IsLeftMouseButtonPressed();
                _isLeftDown = leftPressed && !_wasLeftPressed; // left down when left is pressed but was not pressed in the last frame
                _wasLeftPressed = leftPressed;

                var middlePressed = IsMiddleMouseButtonPressed();
                _isMiddleDown = middlePressed && !_wasMiddlePressed;
                _wasMiddlePressed = middlePressed;

                var rightPressed = IsRightMouseButtonPressed();
                _isRightDown = rightPressed && !_wasRightPressed;
                _wasRightPressed = rightPressed;
            }

            public static void HideMouse()
            {
                _mousePositionWhenHiding = Mouse.current.position.ReadValue();
                Cursor.visible = false;
                Cursor.lockState = CursorLockMode.Locked;
            }

            public static void ShowMouse()
            {
                Cursor.visible = true;
                Cursor.lockState = CursorLockMode.None;

                // set the mouse to its old position
                Mouse.current.WarpCursorPosition(_mousePositionWhenHiding);
            }

            public static Vector2 GetMouseMovement()
            {
                return Mouse.current.delta.ReadValue() / 20; // divide by 20 to get a similar value to the GetAxis of the old input system
            }

            public static Vector2 GetMousePosition()
            {
                return Mouse.current.position.ReadValue();
            }

            // check for mouse buttons
            public static bool IsLeftMouseButtonPressed()
            {
                return Mouse.current.leftButton.isPressed;
            }

            public static bool IsRightMouseButtonPressed()
            {
                return Mouse.current.rightButton.isPressed;
            }

            public static bool IsMiddleMouseButtonPressed()
            {
                return Mouse.current.middleButton.isPressed;
            }

            public static bool IsLeftMouseButtonDown()
            {
                return _isLeftDown;
            }

            public static bool IsMiddleMouseButtonDown()
            {
                return _isMiddleDown;
            }

            public static bool IsRightMouseButtonDown()
            {
                return _isRightDown;
            }
        }
    }

    internal static class InputHelper2
    {
        public static bool IsPressed(this InputAction action)
        {
            return action.ReadValue<float>() > 0;
        }
    }
}

