using UnityEngine;

public class PlayerAnimator : MonoBehaviour
{
    [SerializeField] private Animator _playerAnimation;

    protected float moveX;
    protected float moveZ;

    protected void SetMovementValues(float x, float z)
    {
        moveX = x;
        moveZ = z;
        AnimationInput();
    }

    private void AnimationInput()
    {
        bool isMoving = moveX != 0 || moveZ != 0;  // Check if either moveX or moveZ is not zero, indicating movement
        _playerAnimation.SetBool("Running", isMoving);
    }
}