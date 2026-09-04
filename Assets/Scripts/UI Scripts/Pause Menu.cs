using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PauseMenu : MonoBehaviour
{
    [Header("Canvas")]
    [SerializeField] private GameObject pauseCanvas;
    [SerializeField] private GameObject settingsCanvas;
    [SerializeField] private GameObject creditsCanvas;
    [SerializeField] private GameObject mainMenuCanvas;

    [Header("Buttons")]
    [SerializeField] private Button btnContinue;
    [SerializeField] private Button btnSettings;
    [SerializeField] private Button btnCredits;
    [SerializeField] private Button btnExit;

    public bool isPause = false;

    private void Awake()
    {
        btnContinue.onClick.AddListener(OnContinueClicked);
        btnSettings.onClick.AddListener(OnSettingsClicked);
        btnCredits.onClick.AddListener(OnCreditsClicked);
        btnExit.onClick.AddListener(OnExitClicked);
    }

    void Update()
    {
        if (!mainMenuCanvas.activeSelf) // Checking if the MainMenu is active.
        {
            // Pause Game
            if (Input.GetKeyDown(KeyCode.Escape) || Input.GetKeyDown(KeyCode.P))
            {
                isPause = !isPause;
                pauseCanvas.SetActive(isPause);

                if (isPause)
                {
                    Time.timeScale = 0;
                }
                else
                {
                    Time.timeScale = 1;
                }
            }
        }
    }

    private void OnDestroy()
    {
        btnContinue.onClick.RemoveAllListeners();
        btnSettings.onClick.RemoveAllListeners();
        btnCredits.onClick.RemoveAllListeners();
        btnExit.onClick.RemoveAllListeners();
    }

    // Buttons events
    private void OnContinueClicked()
    {
        isPause = !isPause;
        pauseCanvas.SetActive(isPause);
        Time.timeScale = 1;
    }

    private void OnSettingsClicked()
    {
        settingsCanvas.SetActive(true);
        pauseCanvas.SetActive(false);
    }

    private void OnCreditsClicked()
    {
        creditsCanvas.SetActive(true);
        pauseCanvas.SetActive(false);
    }

    private void OnExitClicked()
    {
        pauseCanvas.SetActive(false);

        // Reset Game
        SceneManager.LoadScene("Scene1");
    }
}
