using UnityEngine;

public class TriggerIncreaseWidth: PlayerWidth
{
    private DeformationType _increasedeformation ;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
          DeformationTypePlayer();
        }
    }

    private void DeformationTypePlayer()
    {
        if (_increasedeformation == DeformationType.Width)
        {
            IncreaseWidth();
        }
    }

    
    
}
