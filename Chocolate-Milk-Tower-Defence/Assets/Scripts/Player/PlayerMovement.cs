using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    //Core
    public CharacterController Controller;

    private Vector3 Velocity;

    public Transform GroundCheck;
    public float GroundDistance = 0.4f;
    public float Gravity = -9.81f;
    public LayerMask GroundMask;
    public bool isGrounded;

    //Stats
    public float Speed = 10.0f;
    public float JumpHeight = 4.0f;




    void Start()
    {

    }

    void Update()
    {
        isGrounded = Physics.CheckSphere(GroundCheck.position, GroundDistance, GroundMask);
        //Creates a tiny invisible sphere to check if the object is grounded or not

        if(isGrounded && Velocity.y < 0)
        {
            Velocity.y = -2.0f;
        }

        float X = Input.GetAxis("Horizontal");
        float Z = Input.GetAxis("Vertical");

        Vector3 MoveDirection = transform.right * X + transform.forward * Z;
        Controller.Move(MoveDirection * Speed * Time.deltaTime);

        if(Input.GetButtonDown("Jump") && isGrounded)
        {
            Velocity.y = Mathf.Sqrt(JumpHeight * -2.0f * Gravity);
            Debug.Log("I should jump");
        }

        Velocity.y += Gravity * Time.deltaTime;

        Controller.Move(Velocity * Time.deltaTime);

        PlayerInputs();
    }

    void PlayerInputs()
    {
        if (Input.GetKeyDown("p"))
        {
            Speed++;
            //Debug.Log(Speed);
        }
    }
}
