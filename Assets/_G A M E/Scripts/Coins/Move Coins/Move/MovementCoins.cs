using UnityEngine;
public class MovementCoins : MonoBehaviour
{
    [SerializeField] private Transform _coinTransform;
    [SerializeField] [Range(0f, 5f)] private float _speedCoins ;
    private void Awake()
    {
       TargetTransform();
    }

    private void Update()
    {
        MoveCoins();
    }

    public void MoveCoins()
    {
        _coinTransform.Translate(Vector3.forward * (_speedCoins * Time.deltaTime), Space.Self);
    }

   public void TargetTransform()
    {
        if (_coinTransform == null)
        {
            _coinTransform ??= transform; 
        }
    }
}