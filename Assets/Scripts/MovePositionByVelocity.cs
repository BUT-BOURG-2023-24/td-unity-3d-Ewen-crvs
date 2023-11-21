using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class MovePositionByVelocity : MonoBehaviour
{
    public float speed = 10.0f;
    public InputActionReference moveInputRef = null;
    public InputActionReference jumpActionRef = null;
    public Rigidbody bodytwo = null;
    public float jumpPower = 100;
    public Rigidbody body = null;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnEnable()
    {
        jumpActionRef.action.performed += OnJumpInputPressed;
    }

    private void OnDisable()
    {
        jumpActionRef.action.performed -= OnJumpInputPressed;
    }

    private void OnJumpInputPressed(InputAction.CallbackContext context)
    {
        Jump();
    }

    private void Jump()
    {
        bodytwo.AddForce(Vector3.up * jumpPower);
    }

    // Update is called once per frame
    void Update()
    {

        Vector2 inputMovement = moveInputRef.action.ReadValue<Vector2>();

        body.velocity = new Vector3(inputMovement.x * speed, body.velocity.y, inputMovement.y * speed);


    }
}
