using UnityEngine;
using UnityEngine.Serialization;

public class SoundCoins : MonoBehaviour
{
   
    [SerializeField] AudioClip _coinSound;
    private AudioSource _audioSource;

    private void Start()
    {
        CoinManager.Instance?.RegisterCoin(gameObject);
        _audioSource = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            if (_coinSound != null)
            {
                AudioSource.PlayClipAtPoint(_coinSound, transform.position);
            }
        
           
        }
    }
}