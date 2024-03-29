using UnityEngine;

public class InputState
{
    public enum InStateType
    {
        NoInput,
        WasdMovement,
        MouseZoom,
        RotateAroundPoint,
        SlideSideways,
        HoldingGizmoTool,
        FocusTransition,
        UiInput
    }

    public InStateType InState = InStateType.NoInput;

    // When Rotating camera around point, this variable keeps track of the point, that is being rotated around
    public Vector3? RotateCameraAroundPoint = null;

    // When the focus button was pressed, this variable keeps track of the position the camera transitions to
    public Vector3? FocusTransitionDestination = null;

    // When holding a gizmo this struct contains information about current gizmo operation.
    public GizmoData? CurrentGizmoData;
    public struct GizmoData
    {
        // The direction in which the gizmo is dragged. In world space.
        public Vector3? dragAxis;
        // Dragging on a plane (e.g. xy-plane) or on a single axis?
        public bool movingOnPlane;
        // The plane on which the mouse position is determined via raycasts.
        public Plane plane;
        // The initial mouse offset to the selected entity at the start of the gizmo drag.
        public Vector3 initialMouseOffset;        
        // The axis around which to rotate. Only relevant when using a rotation gizmo. In local space.
        public Vector3? rotationAxis;

        public GizmoData(Plane mouseCollisionPlane, Vector3 initialMouseOffset, bool movingOnPlane = true, Vector3? dragAxis = null, Vector3? rotationAxis = null)
        {
            this.dragAxis = dragAxis;
            this.movingOnPlane = movingOnPlane;
            this.plane = mouseCollisionPlane;
            this.initialMouseOffset = initialMouseOffset;
            this.rotationAxis = rotationAxis;
        }
    }
}