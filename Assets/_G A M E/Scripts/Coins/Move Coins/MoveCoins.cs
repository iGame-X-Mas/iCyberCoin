using UnityEngine;

public class MoveCoins : MonoBehaviour
{
    [Header("Coin Movement Settings")]
    [SerializeField] private Transform _coinTransform;
    [SerializeField] [Range(0f, 5f)] private float _speedCoins = 1f;

    [Header("Player & Ground Detection")]
    [SerializeField] private GameObject _player;
    [SerializeField] private LayerMask _groundLayer;
    [SerializeField] private float _raycastDistance = 2.2f;

    private Transform _playerTransform; 
    private bool _canMove;

    private void Start()
    {
        if (_player != null)
        {
            _playerTransform = _player.transform;  
        }
       
    }

    private void FixedUpdate()
    {
        UpdateMovementStatus();

        if (_canMove)
        {
            MoveCoin();
        }
    }

    private void UpdateMovementStatus()
    {
        if (_playerTransform == null) return;

        // Raycast directly without storing unnecessary variables
        _canMove = Physics.Raycast(_playerTransform.position, Vector3.down, _raycastDistance, _groundLayer);

        Debug.DrawRay(_playerTransform.position, Vector3.down * _raycastDistance, _canMove ? Color.green : Color.red);
    }

    private void MoveCoin()
    {
        if (_coinTransform == null) return; 

        _coinTransform.Translate(Vector3.forward * (_speedCoins * Time.deltaTime), Space.Self);
    }
    
    
    
/*
 private void MovCoins()
{
    if (_coinTransform == null || _playerTransform == null) return;

    Vector3 direction = (_playerTransform.position - _coinTransform.position).normalized;
    _coinTransform.position += direction * (_speedCoins * Time.deltaTime);
}
*/

}



