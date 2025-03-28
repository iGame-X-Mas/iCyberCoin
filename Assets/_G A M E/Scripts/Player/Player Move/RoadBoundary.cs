using UnityEngine;

public class RoadBoundary : MonoBehaviour
{
    // Define boundary limits for X and Z positions
    private const float maxX = 2.5f;
    private const float minX = -2.5f;
    private const float maxZ = -30f;

    private void LateUpdate()
    {
        ClampPosition();
    }

    private void ClampPosition()
    {
            Vector3 position = transform.position; // Get the current position of the object
            position.x = Mathf.Clamp(position.x, minX, maxX);  // Clamp X position within allowed boundaries
            position.z = Mathf.Max(position.z, maxZ); // Ensure the Z position doesn't go beyond maxZ
            transform.position = position;  // Apply the modified position back to the object
        
    }
}