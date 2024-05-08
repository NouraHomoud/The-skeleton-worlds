using System.Collections;
using System.Collections.Generic;
using UnityEngine;


using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 3f;
    public float jumpForce = 5f;

    private Rigidbody player;
    private bool isGrounded;

    void Start()
    {
        player = GetComponent<Rigidbody>();
    }

    void Update()
    {
        // Movement
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");
        Vector3 moveDirection = new Vector3(horizontalInput, 0f, verticalInput);
        player.AddForce(moveDirection * moveSpeed);

        // Jumping
        if (Input.GetKeyDown(KeyCode.Space))
        {
            player.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);

        }

    }


}
