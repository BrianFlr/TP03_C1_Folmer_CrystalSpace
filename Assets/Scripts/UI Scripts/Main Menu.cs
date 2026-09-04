using UnityEngine;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{
    [Header("Canvas")]
    [SerializeField] private GameObject mainMenuCanvas;
    [SerializeField] private GameObject settingsCanvas;
    [SerializeField] private GameObject creditsCanvas;

    [Header("Buttons")]
    [SerializeField] private Button btnStart;
    [SerializeField] private Button btnSettings;
    [SerializeField] private Button btnCredits;
    [SerializeField] private Button btnExit;

    private void Awake()
    {
        btnStart.onClick.AddListener(OnStartClicked);
        btnSettings.onClick.AddListener(OnSettingsClicked);
        btnCredits.onClick.AddListener(OnCreditsClicked);
        btnExit.onClick.AddListener(OnExitClicked);
    }

    void Start()
    {
        
    }

    void Update()
    {
        
    }

    private void OnDestroy()
    {
        btnStart.onClick.RemoveAllListeners();
        btnSettings.onClick.RemoveAllListeners();
        btnCredits.onClick.RemoveAllListeners();
        btnExit.onClick.RemoveAllListeners();
    }

    // Button Events
    private void OnStartClicked()
    {
        Time.timeScale = 1;
        mainMenuCanvas.SetActive(false);
    }

    private void OnSettingsClicked()
    {
        settingsCanvas.SetActive(true);
        mainMenuCanvas.SetActive(false);
    }

    private void OnCreditsClicked()
    {
        creditsCanvas.SetActive(true);
        mainMenuCanvas.SetActive(false);
    }

    private void OnExitClicked()
    {
        UnityEditor.EditorApplication.isPlaying = false;  
    }
}
