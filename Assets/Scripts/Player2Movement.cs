using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player2Movement : MonoBehaviour
{
    // Start is called before the first frame update
    //how fast we move
    public float speed = 10f;
    public float jumpForce = 5f;
    public float gravity = 20f;
    public float rotSpeed = 90f;
    public playerStats pStats;

    private CharacterController controller;
    Vector3 moveDir;
    Vector3 rot;

    void Start()
    {
        //establish communication with our character controller.
        controller = GetComponent<CharacterController>();
        pStats = GetComponent<playerStats>();
    }

    // Update is called once per frame
    void Update()
    {
        if (pStats.health > 0)
        //Are we on the ground
        {
            if (controller.isGrounded)
            {
                //move along forward/back and left/right.
                moveDir = new Vector3(Input.GetAxis("Horizontal P2"), 0, Input.GetAxis("Vertical P2"));
                //moveDir = transform.TransformDirection(moveDir);  
                moveDir *= speed;
                if ((Input.GetAxis("Horizontal P2") != 0 || Input.GetAxis("Vertical P2") != 0))
                    transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(moveDir), 0.15f);

            }
            //Apply gravity
            moveDir.y -= gravity * Time.deltaTime;
            //move character
            controller.Move(moveDir * Time.deltaTime);
        }
    }
}