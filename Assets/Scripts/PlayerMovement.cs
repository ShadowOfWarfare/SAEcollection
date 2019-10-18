using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // Start is called before the first frame update
    //how fast we move
    public float speed = 10f;
    public float jumpForce = 5f;
    public float gravity = 20f;
    public float rotSpeed = 90f;

    private CharacterController controller;
    Vector3 moveDir;

    void Start()
    {
        //establish communication with our character controller.
        controller = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        //Are we on the ground
        if (controller.isGrounded)
        {
            //move along forward/back and left/right.
            moveDir = new Vector3(0, 0, Input.GetAxis("Vertical"));
            moveDir = transform.TransformDirection(moveDir);
            moveDir *= speed;
        }
        //rotation code
        transform.Rotate(0,Input.GetAxis("Horizontal") * rotSpeed * Time.deltaTime,0);
        //Apply gravity
        moveDir.y -= gravity * Time.deltaTime;
        //move character
        controller.Move(moveDir * Time.deltaTime);
    }
}
