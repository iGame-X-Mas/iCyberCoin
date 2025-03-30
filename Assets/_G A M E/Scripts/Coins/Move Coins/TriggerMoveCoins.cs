using UnityEngine;

public class TriggerMoveCoins : MonoBehaviour
{
    [SerializeField] private float moveSpeed = 3f; // Speed which the coin moves forward
    [SerializeField] private GameObject coin;  // Reference the coin GameObject
    private bool shouldMove; // Flag to check if the coin should start moving

    private void OnTriggerEnter(Collider other) // When the player or ground enter the trigger set shouldMove true
    {
        if (other.CompareTag("Player") || other.CompareTag("Ground"))
            shouldMove = true;
    }

    private void FixedUpdate() // Moves the coin forward constant speed when shouldMove is true
    {
        if (shouldMove && coin)
            coin.transform.Translate(Vector3.forward * (moveSpeed * Time.deltaTime));
    }
    
}
