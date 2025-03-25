using UnityEngine;

public class PlayerBoundaries : MonoBehaviour
{
    [SerializeField] private Transform _boundariesPlayer;
    
     private float _xMin = -2.6f;
     private float _xMax = 2.6f;
    
     private float _zMin = -30f;
     private float _zMax = 108f;



    private void LateUpdate()
    {
        ClampPlayerPosition();
    }
    
    private void ClampPlayerPosition()
    {
        if (_boundariesPlayer == null) ;   // Check if the reference the player Transform is assigned, if not, exit the function

        Vector3 clampedPosition = _boundariesPlayer.position; // Get the current position the player
        
        clampedPosition.x = Mathf.Clamp(clampedPosition.x, _xMin, _xMax);  // Restrict the X position to stay within _xMin and _xMax
        clampedPosition.z = Mathf.Clamp(clampedPosition.z, _zMin, _zMax);  // Restrict the Z position to stay within _zMin and _zMax

        // Update the player position if it has changed 
        if (_boundariesPlayer.position != clampedPosition)
        {
            _boundariesPlayer.position = clampedPosition;
        }
    }
}