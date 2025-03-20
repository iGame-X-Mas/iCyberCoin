using UnityEngine;

  public class TriggerDecreaseHeight : MonoBehaviour
{
    private float _minHeight = 0.9f; 
    [SerializeField] private Transform _transformPlayerDecreaseHeight; 
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player")) 
        {
            // Scale down the player height while maintaining X and Z scales
            _transformPlayerDecreaseHeight.localScale = new Vector3(_transformPlayerDecreaseHeight.localScale.x, _minHeight, _transformPlayerDecreaseHeight.localScale.z);
        }
    }
}