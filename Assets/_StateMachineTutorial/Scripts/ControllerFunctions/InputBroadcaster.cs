using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class InputBroadcaster : MonoBehaviour
{
    public bool IsTapPressed { get; private set; } = false;

    private PlayerInput playerInput;
    private InputAction touchPositionAction;
    private InputAction touchPressAction;
    private InputAction touchReleaseAction;
    private InputAction touchTap;

    private void Awake()
    {
        playerInput = GetComponent<PlayerInput>();
        touchPressAction = playerInput.actions.FindAction("TouchPress");
        touchReleaseAction = playerInput.actions.FindAction("TouchRelease");
        touchPositionAction = playerInput.actions.FindAction("TouchPosition");
        touchTap = playerInput.actions.FindAction("TouchTap");

    }

    private void OnEnable()
    {
        touchPressAction.performed += TouchPressed;
        touchReleaseAction.performed += TouchReleased;
    }

    private void OnDisable()
    {
        touchPressAction.performed -= TouchPressed;
        touchReleaseAction.performed -= TouchReleased;
    }

    private void TouchPressed(InputAction.CallbackContext context)
    {
        IsTapPressed = true;
    }

    private void TouchReleased(InputAction.CallbackContext context)
    {
        IsTapPressed = false;
    }

}
