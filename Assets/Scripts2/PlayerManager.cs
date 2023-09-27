using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    public static PlayerManager Instance { get; private set; }
    // Player GameObject
    public GameObject player;
    public Rigidbody rigidBody;
    // Player Scripts
    public InputManager inputManager;
    PlayerLocomotor playerLocomotor;
    // Player Stats
    public float movementSpeed, rotationSpeed;
    

    private void Awake()
    {
        // If there is an instance, and it's not me, delete myself
        if (Instance != null && Instance != this) { Destroy(this); }
        else { Instance = this; }
        inputManager = player.GetComponent<InputManager>();
        playerLocomotor = player.GetComponent <PlayerLocomotor>();
        rigidBody = player.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    private void Update()
    {
        inputManager.HandleAllInput();
    }

    private void FixedUpdate()
    {
        playerLocomotor.HandleAllMovement();
    }
}
