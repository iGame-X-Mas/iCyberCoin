using UnityEngine;

public class TriggerMoveCoins : MonoBehaviour
{
    [SerializeField] private float moveSpeed = 3f;
    [SerializeField] private GameObject coin;
    private bool shouldMove;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") || other.CompareTag("Ground"))
            shouldMove = true;
    }

    private void FixedUpdate()
    {
        if (shouldMove && coin)
            coin.transform.Translate(Vector3.forward * (moveSpeed * Time.deltaTime));
    }
    
}
