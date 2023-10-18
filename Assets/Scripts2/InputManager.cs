using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Unity.VisualScripting;
using UnityEngine;

public class InputManager : MonoBehaviour
{
    private PlayerControls playerControls;
    public Vector2 movementInput;
    public float verticalInput, horizontalInput, moveAmount;
    public bool sprint_Input, walk_Input;

    // Heiarchy:
    // void Awake
    // void Enable
    private void OnEnable()
    {
        if (playerControls == null)
        {
            playerControls = new PlayerControls();
            // when WASD is pressed, records the movement to variable
            // PlayerMovement is from PlayerControls Input Action
            playerControls.PlayerMovement.Movement.performed += i => movementInput = i.ReadValue<Vector2>();
            playerControls.PlayerAction.Sprint.performed += i => sprint_Input = true;
            playerControls.PlayerAction.Sprint.canceled += i => sprint_Input = false;

            playerControls.PlayerAction.Walk.performed += i => walk_Input = true;
            playerControls.PlayerAction.Walk.canceled += i => walk_Input = false;
        }
        playerControls.Enable();
    }

    public void OnDisable()
    {
        playerControls.Disable();
    }
    public void HandleAllInput()
    {
        HandleMovementInput();
        HandleSprinting();
    }
    private void HandleMovementInput()
    {
        verticalInput = movementInput.y;
        horizontalInput = movementInput.x;

        moveAmount = Mathf.Clamp01(Mathf.Abs(horizontalInput) + Mathf.Abs(verticalInput));
        PlayerManager.Instance.playerAnimation.UpdateAnimatorValues(0, moveAmount);
    }

    private void HandleSprinting()
    {
        if (sprint_Input && moveAmount > 0.5)
        {
            PlayerManager.Instance.isSprinting = true;
        }
        else
        {
            PlayerManager.Instance.isSprinting = false;
        }
    } 
}
