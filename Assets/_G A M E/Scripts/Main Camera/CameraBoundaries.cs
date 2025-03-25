using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraBoundaries : MonoBehaviour
{
    [SerializeField] private Transform _camBoundaries;
    
    private float _xMin = -2.6f;
    private float _xMax = 2.6f;
    
    private float _zMin = -30f;
    private float _zMax = 108f;
    
    private void LateUpdate()
    {
        ClampCamPosition();
    }



 private void  ClampCamPosition()
    {
        
        if (!_camBoundaries) ;   // Check if the reference the Cam Transform is assigned, if not, exit the function

        Vector3 camBoundariesPosition = _camBoundaries.position; // Get the current position the Cam
        
        camBoundariesPosition.x = Mathf.Clamp(camBoundariesPosition.x, _xMin, _xMax);  // Restrict the X position to stay within _xMin and _xMax
        camBoundariesPosition.z = Mathf.Clamp(camBoundariesPosition.z, _zMin, _zMax);  // Restrict the Z position to stay within _zMin and _zMax

        // Update the cam position if it has changed 
        if (_camBoundaries.position != camBoundariesPosition)
        {
            _camBoundaries.position = camBoundariesPosition;
        }
    }
    
    
    
}
