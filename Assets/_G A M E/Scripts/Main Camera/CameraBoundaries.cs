using UnityEngine;

public class CameraBoundaries : MonoBehaviour
{
    [SerializeField] private Transform _camBoundaries;

    [SerializeField] private float _xMin = -2.6f;
    [SerializeField] private float _xMax = 2.6f;
    
    [SerializeField] private float _zMin = -30f;
    [SerializeField] private float _zMax = 108f;

    private void LateUpdate()
    {
        ClampCamPosition();
    }

    private void ClampCamPosition()
    {
        if (_camBoundaries == null) return; // Proper null check

        Vector3 clampedPosition = _camBoundaries.position;
        clampedPosition.x = Mathf.Clamp(clampedPosition.x, _xMin, _xMax);
        clampedPosition.z = Mathf.Clamp(clampedPosition.z, _zMin, _zMax);

        _camBoundaries.position = clampedPosition; // No need to check if it already the same
    }
}