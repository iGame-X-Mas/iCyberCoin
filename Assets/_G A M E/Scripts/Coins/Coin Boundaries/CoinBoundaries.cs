using UnityEngine;
public class CoinBoundaries : MonoBehaviour
{ 
    [SerializeField] private Transform _transformCoins;
    [SerializeField] private float _destructionBoundariesCoins = -32f; 

    private void Awake()
    {
        _transformCoins ??= transform;  // If "_transformCoins" is not assigned (null), assign it the transform GameObject this script attached 
    }

    private void LateUpdate()
    {
        if (_transformCoins.position.z < _destructionBoundariesCoins) // Check if coins Z-position is less than the destruction boundary
        {
            Destroy(gameObject);
        }
    }
}