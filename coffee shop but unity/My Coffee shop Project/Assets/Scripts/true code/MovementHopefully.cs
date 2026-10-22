using UnityEngine;
using UnityEngine.InputSystem;

[RequireComponent(typeof(CharacterController))]

public class MovementHopefully : MonoBehaviour
{
    [SerializeField] private float WalkSpeed = 5.5f;
    [SerializeField] private float RunningSpeed = 9.0f;

    [SerializeField] private float JumpForce = 8.00f;
    [SerializeField] private float Gravity = 20.0f;

    [SerializeField] private float LookSensitivity  = 0.2f;
    [SerializeField] private float LookingAngleLimit = 90f;

    Camera playerCamera;
    CharacterController characterController;

    private InputAction moveInput;
    private InputAction runInput;

    private InputAction jumpInput;
    private bool jumped = false;

    private float currentMoveSpeed = 0.0f;
    private Vector3 moveDirection = Vector3.zero;
    private float lookAngle = 0.0f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private void Start()
    {
        playerCamera = GetComponentInChildren<Camera>();
        characterController = GetComponent<CharacterController>();

        moveInput = InputSystem.actions.FindAction("Move");
        runInput = InputSystem.actions.FindAction("Sprint");
        jumpInput = InputSystem.actions.FindAction("Jump");

        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
        currentMoveSpeed = WalkSpeed;
    }

    // Update is called once per frame
    private void Update()
    {
        Vector2 moveVector = moveInput.ReadValue<Vector2>();
        if (!characterController.isGrounded)
            jumped = false;
        currentMoveSpeed = runInput.IsPressed() ? RunningSpeed : WalkSpeed
        HandleMovement(moveVector);
    }
    private void HandleMovement(Vector2 moveVector)
    {
        Vector3 forward = transform.TransformDirection(Vector3.forward);
        Vector3 right = transform.TransformDirection(Vector3.right);

        float oldY = moveDirection.y;

        Vector2 newSpeed = new Vector2(moveVector.y * currentMoveSpeed, moveVector.x * currentMoveSpeed);

        moveDirection = (forward * newSpeed.x) + (right  * newSpeed.y);
        if (jumped && characterController.isGrounded)
            moveDirection.y = JumpForce;
        else
            moveDirection.y = oldY;

        characterController.Move(moveDirection * Time.deltaTime);

    }
    private void Jumped(InputAction.CallbackContext _)
    {
        jumped = true;
    }
}
