using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private CharacterController characterController;
    [SerializeField] private float moveSpeed = 3.5f;

    [SerializeField] Transform Boat;

    bool Paddle = false;
    // Start is called before the first frame update
    void Start()
    {
        characterController = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.F))
        {
            Paddle = !Paddle;
        }
        if (Paddle == false)
        {
            if (Input.GetKeyDown(KeyCode.Q))
            {
                transform.Rotate(0, 45, 0); // Rotate player 45 degrees left
            }
            if (Input.GetKeyDown(KeyCode.E))
            {
                transform.Rotate(0, -45, 0); // Rotate player 45 degrees right
            }

            // Get horizontal (A/D keys) and vertical (W/S keys) input
            float horizontalInput = Input.GetAxisRaw("Horizontal"); // Left/Right
            float verticalInput = Input.GetAxisRaw("Vertical"); // Forward/Backward

            // Create a movement vector relative to the player's local space
            Vector3 moveDirection = transform.right * horizontalInput + transform.forward * verticalInput;
            // Apply movement to the character controller
            characterController.Move(moveDirection * moveSpeed * Time.deltaTime);

            
        }
        if (Paddle == true)
        {
            if (Input.GetKeyDown(KeyCode.Q))
            {
                transform.Rotate(0, 45, 0); // Rotate player 45 degrees left
            }
            if (Input.GetKeyDown(KeyCode.E))
            {
                transform.Rotate(0, -45, 0); // Rotate player 45 degrees right
            }

            // Get horizontal (A/D keys) and vertical (W/S keys) input
            float horizontalInput = Input.GetAxisRaw("Horizontal"); // Left/Right
            float verticalInput = Input.GetAxisRaw("Vertical"); // Forward/Backward

            // Create a movement vector relative to the player's local space
            Vector3 moveDirection = transform.right * horizontalInput + transform.forward * verticalInput;
            // Apply movement to the character controller
            characterController.Move += (moveDirection * moveSpeed * Time.deltaTime);
        }
    }
}
