using UnityEngine;

  public class TriggerDecreaseHeight : MonoBehaviour
{
    private float _minHeight = 0.9f; 
    [SerializeField] private Transform _transformPlayerDecreaseHeight; 
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            _transformPlayerDecreaseHeight.localScale = new Vector3(_transformPlayerDecreaseHeight.localScale.x, _minHeight, _transformPlayerDecreaseHeight.localScale.z);
        }
    }
}