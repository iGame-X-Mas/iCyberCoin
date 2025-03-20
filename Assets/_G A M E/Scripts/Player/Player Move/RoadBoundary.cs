using UnityEngine;

public class RoadBoundary : MonoBehaviour
{
    
     private float maX = 2.5f;
     private float minX = -2.5f;
     private float maxZ = -30f;

    private void LateUpdate()
    {
        ClampPosition();
    }

    private void ClampPosition()
    {
        Vector3 position = transform.position;
        transform.position = position;
        
        position.x = Mathf.Clamp(position.x, minX, maX);  
        position.z = Mathf.Max(position.z, maxZ);
       
    }
}