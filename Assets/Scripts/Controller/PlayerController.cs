using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

/// <summary>
/// This class handles the movement of the player with given input from the input manager
/// </summary>
public class PlayerController : MonoBehaviour
{
    //[Header("Setting")]
    //public float moveSpeed = 2f;
    //public float lockSpeed = 60f;
    //public float JumpPower = 8f;
    //public float gravity = 9.81f;
    [Header("Required Performance")]
    public Shooter playerShooter;
    public Health health;
    public List<GameObject> disabledWhileDead;

    // The character controller component as the player
    //private CharacterController controller;
    //private InputManager inputManager;

    
    ///// <summary>
    ///// Description:
    ///// Standard Unity function called once before the first Update call
    ///// Input:
    ///// none
    ///// Return:
    ///// void (no return)
    ///// </summary>
  
    //void Start()
    //{
    //    SetUpCharacterController();
    //    SetUpInputManager();
    //}

    //private void SetUpCharacterController()
    //{
    //    controller = GetComponent<CharacterController>();
    //    if (controller == null)
    //    {

    //    }
    //}

    //private void SetUpInputManager()
    //{
    //    inputManager = GetComponent<InputManager>();
    //}

    ///// <summary>
    ///// Description:
    ///// Standard Unity function called once every frame
    ///// Input:
    ///// none
    ///// Return:
    ///// void (no return)
    ///// </summary>
    
    void Update()
    {
    //    ProcessMovement();
    //    ProcessRotation();
        if(health.currentHealth <= 0)
        {
            foreach (GameObject inGameObject in disabledWhileDead)
            {
                inGameObject.SetActive(false);
            }
            return;
        }
        else
        {
            foreach (GameObject inGameObject in disabledWhileDead)
            {
                inGameObject.SetActive(true);
            }
        }
    }

    //Vector3 moveDirection;

    //void ProcessMovement()
    //{
    //    // Get Information from Input Manager
    //    float leftrightInput = Input.GetAxis("Vertical") * moveSpeed;
    //    float forwardbackwardInput = inputManager.verticalMoveAxis;
    //    bool jumpPressed = inputManager.jumpPressed;

    //    // Handle control of player while on the ground
    //    if (controller.isGrounded)
    //    {
    //        // Set the movement direction to be recieved input, set y to 0 since we are on the ground
    //        moveDirection = new Vector3(leftrightInput, 0, forwardbackwardInput);
    //        // Set the move direction in relation to the transform
    //        moveDirection = transform.TransformDirection(moveDirection);
    //        moveDirection = moveDirection * moveSpeed;

    //        if (jumpPressed)
    //        {
    //            moveDirection.y = JumpPower;
    //        }
    //    }
    //    else
    //    {
    //        moveDirection = new Vector3(leftrightInput * moveSpeed, moveDirection.y, forwardbackwardInput * moveSpeed);
    //        moveDirection = transform.TransformDirection(moveDirection);
    //    }

    //    moveDirection.y -= gravity * Time.deltaTime;

    //    controller.Move(moveDirection * Time.deltaTime);

    //}

    //void ProcessRotation()
    //{
    //    float horizontalLookInput = inputManager.horizontalLookAxis;
    //    Vector3 playerRotation = transform.rotation.eulerAngles;
    //    transform.rotation = Quaternion.Euler(new Vector3(playerRotation.x, playerRotation.y * horizontalLookInput * lockSpeed * Time.deltaTime,
    //        playerRotation.z));

    //}

}
