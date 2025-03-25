using UnityEngine;
public class CoinBoundaries : MonoBehaviour
{ 
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("DestroyBoundariesCoins"))
        {
            DestroyCoins();
        }
    }
    
    private void DestroyCoins()
    {
        Destroy(gameObject);
    }
}