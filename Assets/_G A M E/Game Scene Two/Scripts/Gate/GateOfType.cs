using UnityEngine;

[ExecuteAlways]
public class GateOfType : MonoBehaviour
{
    [Header("Gate Configuration")]
    [SerializeField] private int _value;
    [SerializeField] private DeformationType _deformationType;

    [Header("Gate Appearance")]
    [SerializeField] private GateAppearance _gateAppearance;

    private void OnValidate()
    {
        
        if (_gateAppearance == null)
        {
            Debug.LogWarning($"{nameof(GateOfType)}: Missing GateAppearance reference on {gameObject.name}", this);
            return;
        }
        
        UpdateGateAppearance();
    }
    
    private void UpdateGateAppearance()
    {
        _gateAppearance.UpdateVisual(_deformationType, _value);
    }
}