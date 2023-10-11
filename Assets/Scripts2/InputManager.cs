using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class InputManager : MonoBehaviour
{
    private PlayerControls playerControl;
    public Vector2 movementInput;
    public float verticalInput, horizontalInput;
    public float moveAmount;

    // Heiarchy:
    // void Awake
    // void Enable
    private void OnEnable()
    {
        if (playerControl == null)
        {
            playerControl = new PlayerControls();
            // when WASD is pressed, records the movement to variable
            // PlayerMovement is from PlayerControls Input Action
            playerControl.PlayerMovement.Movement.performed += i => movementInput = i.ReadValue<Vector2>();
        }
        playerControl.Enable();
    }

    public void OnDisable()
    {
        playerControl.Disable();
    }
    public void HandleAllInput()
    {
        HandleMovementInput();
    }
    private void HandleMovementInput()
    {
        verticalInput = movementInput.y;
        horizontalInput = movementInput.x;

        moveAmount = Mathf.Clamp01(Mathf.Abs(horizontalInput) + Mathf.Abs(verticalInput));
        PlayerManager.Instance.playerAnimation.UpdateAnimatorValues(0, moveAmount);
    }
}
