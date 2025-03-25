using UnityEngine;
public class MovementBlock : MonoBehaviour
{
    [Header("Movement: Block-Vfx and Block-Obstacle")]
    
    [SerializeField] private Transform _transformBlock;
    [SerializeField] [Range(0f, 5f)] private float _speedBlock;
   
    
    private void Awake()
    {
        TargetTransform();
    }

    private void Update()
    {
        MoveBlock();
    }

    public void MoveBlock()
    {
        _transformBlock.Translate(Vector3.forward * (_speedBlock * Time.deltaTime), Space.Self);
    }

    public void TargetTransform()
    {
        if (_transformBlock == null) 
        {
            _transformBlock ??= transform; 
        }
    }
    
}
