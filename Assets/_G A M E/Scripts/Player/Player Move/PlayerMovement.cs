using UnityEngine;

[RequireComponent(typeof(CharacterController))]
public class PlayerMovement : PlayerAnimator
{
    [SerializeField] private CharacterController _characterController;
    [SerializeField] [Range(0f, 5f)] private float _normalSpeed = 5f;
    [SerializeField] [Range(0f, 10f)] private float _sprintSpeed = 8f;
     private float _gravity = 9.81f;
    
    private Vector3 _velocity;
    private bool _isGrounded;

    private void Awake()
    {
        _characterController = GetComponent<CharacterController>();
    }

    private void Update()
    {
        _isGrounded = _characterController.isGrounded; // Check if player is on the ground
        
        MoveCharacter();
        ApplyGravity();
    }

    private void MoveCharacter()
    {
        if (!_isGrounded) return; // Prevents mid-air movement

        float moveX = Input.GetAxisRaw("Horizontal");
        float moveZ = Mathf.Max(0, Input.GetAxisRaw("Vertical")); // Prevent backward movement

        SetMovementValues(moveX, moveZ);

        Vector3 move = (transform.right * moveX + transform.forward * moveZ).normalized;
        float speed = Input.GetKey(KeyCode.LeftShift) ? _sprintSpeed : _normalSpeed;

        _characterController.Move(move * (speed * Time.deltaTime));
    }

    private void ApplyGravity()
    {
        if (_isGrounded && _velocity.y < 0)
        {
            _velocity.y = -2f; // Small downward force to keep grounded
        }
        else
        {
            _velocity.y -= _gravity * Time.deltaTime;
        }

        _characterController.Move(_velocity * Time.deltaTime);
    }
}