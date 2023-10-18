using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    public static PlayerManager Instance { get; private set; }
    // Player GameObject
    [Header("Game Objects")]
    public GameObject player;
    public Rigidbody rigidBody;
    // Player Scripts
    [Header("Scripts")]
    public InputManager inputManager;
    PlayerLocomotor playerLocomotor;
    // Player Stats
    [Header("Stats")]
    [Range(0f, 10)]
    public float movementSpeed;
    [Range(0f, 50)]
    public float rotationSpeed, sprintSpeed, walkSpeed;
    // Player Animator
    [Header("Animator")]
    public Animator playerAnim;
    public PlayerAnimation playerAnimation;
    [Header("ActionStatus")]
    public bool isSprinting;
    public bool isWalking;
    public bool isJumping;


    private void Awake()
    {
        // If there is an instance, and it's not me, delete myself
        if (Instance != null && Instance != this) { Destroy(this); }
        else { Instance = this; }
        inputManager = player.GetComponent<InputManager>();
        playerLocomotor = player.GetComponent <PlayerLocomotor>();
        rigidBody = player.GetComponent<Rigidbody>();
        playerAnim = player.GetComponentInChildren<Animator>();
        playerAnimation = player.GetComponentInChildren<PlayerAnimation>();
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
