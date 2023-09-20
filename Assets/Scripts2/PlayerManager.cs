using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    public static PlayerManager instance { get; private set; }
    public GameObject player;
    InputManager inputManager;
    PlayerLocomotor playerLocomotor;
    public float movementSpeed, rotationSpeed;
    

    private void Awake()
    {
        // If there is an instance, and it's not me, delete myself
        if (instance != null && instance != this) { Destroy(this); }
        else { instance = this; }
        inputManager = player.GetComponent<InputManager>();
        playerLocomotor = player.GetComponent <PlayerLocomotor>();
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
