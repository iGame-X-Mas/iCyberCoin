using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartUiMenu : MonoBehaviour
{
    [Header("UI References")]
    
    [SerializeField] private GameObject _startMenu;
    [SerializeField] private TextMeshProUGUI _levelName;

    private void Start()
    {
        UpdateLevelName();
    }

    private void UpdateLevelName() //  Updates the level name text in the UI
    {
        if (_levelName == null)
        {
            Debug.LogWarning("Level Name Text is not assigned in StartUiMenu", this);
            return;
        }

        _levelName.text = CurrentSceneName;  // Set the text to the current scene name
    }

    private string CurrentSceneName => SceneManager.GetActiveScene().name;  // Get the current scene name

    public void HideStartMenu()  // Method to hide the start menu
    {
        if (_startMenu == null)
        {
            Debug.LogWarning("Start Menu is not assigned in StartUiMenu", this);
            return;
        }

        _startMenu.SetActive(false);    // Deactivate the start menu GameObject
    }
}