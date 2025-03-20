using UnityEngine;
public class TriggerIncreaseHeight : MonoBehaviour
{
    private float _maxHeight = 1.9f;
    [SerializeField] private Transform _transformPlayerIncreaseHeight;
   
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            _transformPlayerIncreaseHeight.localScale = new Vector3(_transformPlayerIncreaseHeight.localScale.x, _maxHeight, _transformPlayerIncreaseHeight.localScale.z);
        }
    }
}