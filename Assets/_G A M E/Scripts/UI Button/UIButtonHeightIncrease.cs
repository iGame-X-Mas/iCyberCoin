using UnityEngine;
using UnityEngine.Serialization;

public class UIButtonHeightIncrease : MonoBehaviour
{
     [SerializeField] private Transform _transformPlayer;
     private float _maxHeight = 1.9f; 
     
     
    public void IncreasePlayerHeight()
    {
        if (_transformPlayer == null)
        {
            Debug.LogWarning("Target transform is not assigned", this);
            return;
        }
        
        Vector3 newScale = _transformPlayer.localScale;
        newScale.y = _maxHeight;
        _transformPlayer.localScale = newScale;
    }
}