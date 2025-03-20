using TMPro;
using UnityEngine;
using UnityEngine.UI;

public enum DeformationType
{
    Width,
    Height
}

public class GateAppearance : MonoBehaviour
{
    #region UI Elements
    
    [Header("Width Indicators")]
    [SerializeField] private GameObject _expandLabel;
    [SerializeField] private GameObject _shrinkLabel;

    [Header("Height Indicators")]
    [SerializeField] private GameObject _upLabel;
    [SerializeField] private GameObject _downLabel;
        
    [Header("Images & Colors")]
    [SerializeField] private Image _glassImage;
    [SerializeField] private Image _topImage;
    [SerializeField] private Color _positiveColor;
    [SerializeField] private Color _negativeColor;
    #endregion

    
    public void UpdateVisual(DeformationType deformationType, int value)
    {
        // Update the text and color state
        UpdateTextAndColor(value);

        // Reset all active labels before setting the correct one
        ResetLabels();

        // Activate appropriate indicators based on the deformationType and value
        ActivateLabel(deformationType, value);
    }
    
    private void UpdateTextAndColor(int value)
    {
        string prefix = value > 0 ? "+" : "";
        

        if (value > 0)
        {
            SetColor(_positiveColor);
        }
        else if (value < 0)
        {
            SetColor(_negativeColor);
        }
        else
        {
            SetColor(Color.gray);
        }
    }

   
    private void ActivateLabel(DeformationType deformationType, int value)
    {
        if (deformationType == DeformationType.Width)
        {
            ToggleWidthLabels(value);
        }
        else if (deformationType == DeformationType.Height)
        {
            ToggleHeightLabels(value);
        }
    }

    
    private void ToggleWidthLabels(int value)
    {
        if (value > 0)
        {
            _expandLabel.SetActive(true);
        }
        else if (value < 0)
        {
            _shrinkLabel.SetActive(true);
        }
    }

    
    private void ToggleHeightLabels(int value)
    {
        if (value > 0)
        {
            _upLabel.SetActive(true);
        }
        else if (value < 0)
        {
            _downLabel.SetActive(true);
        }
    }

    
    private void SetColor(Color color)
    {
        _topImage.color = color;
        _glassImage.color = new Color(color.r, color.g, color.b, 0.5f);
    }

    
    private void ResetLabels()
    {
        _expandLabel.SetActive(false);
        _shrinkLabel.SetActive(false);
        _upLabel.SetActive(false);
        _downLabel.SetActive(false);
    }

    
}