using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLocomotor : MonoBehaviour
{
    InputManager inputManager;
    Vector3 moveDirection;
    Transform cameraObject;
    Rigidbody playerRigidBody;
    // Start is called before the first frame update
    private void Awake()
    {
        inputManager = GetComponent<InputManager>();
        playerRigidBody = GetComponent<Rigidbody>();
        cameraObject = Camera.main.transform;
    }

    public void HandleAllMovement()
    {
        HandleAllMovement();
        HandleRotation();
    }

    private void HandleMovement()
    {
        // move Direction
    }

    private void HandleRotation()
    {

    }
}
