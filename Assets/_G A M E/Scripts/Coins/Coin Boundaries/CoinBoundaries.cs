using System;
using UnityEngine;
public class CoinBoundaries : MonoBehaviour
{ 
    
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Coin")) // Ensure coins have the "Coin" tag
        {
            Destroy(other.gameObject);
        }
    }

   
}

