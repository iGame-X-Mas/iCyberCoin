using UnityEngine;

public class PlayerWidth: MonoBehaviour
{
  private float  _increasePushvalue = 0.1f; 
  private float  _decreasePushvalue = 0f;

 [SerializeField] private Renderer _rendererPlayer;
 
    public void IncreaseWidth()
    {
        if (_rendererPlayer)
        {
            _rendererPlayer.material.SetFloat("_PushValue",  _increasePushvalue);
        }
    }

    public void DecreaseWidth()
    {
        _rendererPlayer.material.SetFloat("_PushValue",_decreasePushvalue);
    }
}