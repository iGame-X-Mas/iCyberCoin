using UnityEngine;

public class TriggerBarrierVfx: MonoBehaviour
{

    [SerializeField] GameObject _bricksEffectPrefab;

    private void OnTriggerEnter(Collider other)
    {
       
        if (other.CompareTag("Player")) 
        {
            Destroy(gameObject);
            Instantiate(_bricksEffectPrefab, transform.position, transform.rotation);
        }
    }

}
