using UnityEngine;
using UnityEngine.Serialization;

[RequireComponent(typeof(CharacterController))]
public class PlayerMovement : PlayerAnimator
{
    private CharacterController _characterController;
    [SerializeField] [Range(0f,5f)] private float _normalSpeed = 5f; 
    [SerializeField] [Range(0f,10f)] private float _sprintSpeed = 8f;

    private void Awake()
    {
        _characterController = GetComponent<CharacterController>();
    }

    private void Update()
    {
        MoveCharacter();
    }

    private void MoveCharacter()
    {
        float moveX = Input.GetAxisRaw("Horizontal");
        float moveZ = Mathf.Max(0, Input.GetAxisRaw("Vertical")); // Prevent backward movement

        // Set values for animation
        SetMovementValues(moveX, moveZ);

        Vector3 move = (transform.right * moveX + transform.forward * moveZ).normalized;
        float speed = Input.GetKey(KeyCode.LeftShift) ? _sprintSpeed : _normalSpeed;

        _characterController.Move(move * (speed * Time.deltaTime));
    }
}