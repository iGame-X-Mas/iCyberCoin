using System;
using UnityEngine;

public class CameraControl : MonoBehaviour
{
    [SerializeField] private Camera _playerCamera; // Reference the Camera component the player

    private float _mouseSensitivity = 2.0f; // Sensitivity  the mouse movement
    private float _maximumAngles_X = 60f; // Maximum upward rotation angle for the camera
    private float _minimumAngles_Y = -60f; // Minimum downward rotation angle for the camera


    [Header("Tracking vertical and horizontal rotation of the camera")]
    private float _currentRotationX; // Current vertical rotation the camera

    private float _currentRotationY; // Current horizontal rotation the camera


    private void Update()
    {
       
        MouseLook();
    }
    
    private void MouseLook()
    {
        // Get mouse input
        Vector2 mouseInput = new Vector2(Input.GetAxis("Mouse X"), Input.GetAxis("Mouse Y")) * _mouseSensitivity;

        // Invert Y-axis for natural movement (look up/down)
        _currentRotationX -= mouseInput.y;
        _currentRotationY += mouseInput.x;

        _currentRotationX =
            Mathf.Clamp(_currentRotationX, _minimumAngles_Y,_maximumAngles_X); // Clamp the vertical rotation to prevent flipping
        
    }

    

    

 

}