using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class UiSettingsMenu : MonoBehaviour
{
    [Header("Canvas")]
    [SerializeField] private GameObject settingsCanvas;
    [SerializeField] private GameObject mainMenuCanvas;
    [SerializeField] private GameObject pauseCanvas;
    [SerializeField] private UiManager pauseState;

    [Header("Buttons")]
    [SerializeField] private Button btnBack;

    [Header("Sliders")]
    [SerializeField] private Slider sliderPlayer1Speed;
    [SerializeField] private Slider sliderPlayer2Speed;
    [SerializeField] private TMP_Text textPlayer1Speed;
    [SerializeField] private TMP_Text textPlayer2Speed;

    [Header("Players")]
    [SerializeField] private Move Player1;
    [SerializeField] private Move Player2;


    private void Awake()
    {
        btnBack.onClick.AddListener(OnBackClicked);
        sliderPlayer1Speed.onValueChanged.AddListener(OnPlayer1SpeedChanged);
        sliderPlayer2Speed.onValueChanged.AddListener(OnPlayer2SpeedChanged);
    }

    private void OnDestroy()
    {
        btnBack.onClick.RemoveAllListeners();
        sliderPlayer1Speed.onValueChanged.RemoveAllListeners();
        sliderPlayer2Speed.onValueChanged.RemoveAllListeners();
    }

    // Custom Functions
    private void OnBackClicked()
    {
        settingsCanvas.SetActive(false);

        if (pauseState.isPause)
        {
            pauseCanvas.SetActive(true);
        }
        else
        {
            mainMenuCanvas.SetActive(true);
        }
    }

    private void OnPlayer1SpeedChanged(float value)
    {
        Player1.Speed = value;
        textPlayer1Speed.text = value.ToString("F2");
    }

    private void OnPlayer2SpeedChanged(float value)
    {
        Player2.Speed = value;
        textPlayer2Speed.text = value.ToString("F2");
    }

    private void OnPlayer1LongChanged(float value)
    {
        Player1.Speed = value;
        textPlayer1Speed.text = value.ToString("F2");
        transform.localScale = new Vector3(1, 10, 1);
    }
    private void OnPlayer2LongChanged(float value)
    {
        Player1.Speed = value;
        textPlayer1Speed.text = value.ToString("F2");
        transform.localScale = new Vector3(1, 10, 1);
    }

}
