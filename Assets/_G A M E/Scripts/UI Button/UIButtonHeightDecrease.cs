using UnityEngine;


public class UIButtonHeightDecrease : MonoBehaviour
{
    [SerializeField] private Transform _playerTransformDecrease;
    private float _minHeight = 0.9f; 
   

   
    public void DecreasePlayerHeight()
    {
        if (_playerTransformDecrease==null)
        {
            Debug.LogWarning("Target transform is not assigned", this);
            return;
        }
        
        Vector3 newScale = _playerTransformDecrease.localScale;
        newScale.y = _minHeight;
        _playerTransformDecrease.localScale = newScale;
    }
}
