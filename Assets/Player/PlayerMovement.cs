using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public FlipOnButtonPress flip;

    public CharacterController2D controller;

    float horizontalMove = 0f;

    float runSpeed = 60f;
    bool jump = false;

    // Update is called once per frame
    void Update()
    {
        runSpeed = 60f * flip.facing;

        horizontalMove = Input.GetAxisRaw("Horizontal") * runSpeed;

        if (Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.UpArrow) || Input.GetKeyDown(KeyCode.Space))
        {
            jump = true;
        }

    }

    private void FixedUpdate()
    {
        // Move our character
        controller.Move(horizontalMove * Time.fixedDeltaTime, jump);
        jump = false;
    }
}
