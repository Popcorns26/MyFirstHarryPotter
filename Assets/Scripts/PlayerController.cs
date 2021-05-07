using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

[RequireComponent(typeof(CapsuleCollider))]
[RequireComponent(typeof(CharacterController))]
public class PlayerController : MonoBehaviour
{
    private CharacterController controller;
    private InputActions inputs;
    //private Rigidbody rb;
    private float movementX;
    private float movementY;
    public float speed = 1;

    public float turnSmoothTime = 0.1f;
    private float turnSmoothVelocity;
    public Transform cam;

    private void Awake()
    {
        inputs = new InputActions();
        inputs.Player.Move.performed += context => SendMessage();
    }

    private void SendMessage()
    {
        Debug.Log("Moved");
    }

    // Start is called before the first frame update
    void Start()
    {
        //rb = GetComponent<Rigidbody>();
        controller = GetComponent<CharacterController>();
    }
    private void Update()
    {
        Vector3 movement = new Vector3(movementX, 0.0f, movementY);
        if (movement.magnitude >= 0.1f)
        {
            float targetAngle = Mathf.Atan2(movement.x, movement.z) * Mathf.Rad2Deg + cam.eulerAngles.y;
            float angle = Mathf.SmoothDampAngle(transform.eulerAngles.y, targetAngle, ref turnSmoothVelocity, turnSmoothTime);
            transform.rotation = Quaternion.Euler(0f,angle,0f);

            Vector3 moveDir = Quaternion.Euler(0f, targetAngle, 0f) * Vector3.forward;
            controller.Move(moveDir * speed * Time.deltaTime);
        }
    }
    // Update is called once per frame
    void FixedUpdate()
    {
        
        //rb.velocity = new Vector3(movementX, rb.velocity.y, movementY);
    }
    private void OnMove(InputValue movementValue)
    {
        Vector2 movementVector = movementValue.Get<Vector2>();

        movementX = movementVector.x;
        movementY = movementVector.y;
    }
}
