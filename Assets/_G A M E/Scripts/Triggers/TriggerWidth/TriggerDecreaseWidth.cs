using UnityEngine;

public class TriggerDecreaseWidth: PlayerWidth
{
     private DeformationType _decreaseDeformation;
    private void OnTriggerEnter(Collider other)
    {
        DeformationTypePlayer();
    }
    
    private void DeformationTypePlayer()
    {
        if (_decreaseDeformation == DeformationType.Width)
        {
            DecreaseWidth();
        }
    }
}
