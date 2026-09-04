using UnityEditor;
using UnityEngine;
using UnityEngine.UI;

public class CreditsMenu : MonoBehaviour
{
    [Header("Canvas")]
    [SerializeField] private GameObject creditsCanvas;
    [SerializeField] private GameObject mainMenuCanvas;
    [SerializeField] private GameObject pauseCanvas;
    [SerializeField] private PauseMenu pauseState;

    [Header("Buttons")]
    [SerializeField] private Button btnBack;

    private void Awake()
    {
        btnBack.onClick.AddListener(OnBackClicked);
    }

    private void OnDestroy()
    {
        btnBack.onClick.RemoveAllListeners();
    }

    // Buttons Events
    private void OnBackClicked()
    {
        creditsCanvas.SetActive(false);

        if (pauseState.isPause)
        {
            pauseCanvas.SetActive(true);
        }
        else
        {
            mainMenuCanvas.SetActive(true);
        }
    }
}
