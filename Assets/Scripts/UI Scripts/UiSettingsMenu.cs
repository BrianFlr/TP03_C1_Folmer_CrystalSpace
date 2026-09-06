using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class UiSettingsMenu : MonoBehaviour
{
    [Header("Canvas")]
    [SerializeField] private GameObject settingsCanvas;
    [SerializeField] private GameObject mainMenuCanvas;
    [SerializeField] private GameObject pauseCanvas;

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

    // Eventos de botones
    private void OnBackClicked()
    {
        settingsCanvas.SetActive(false);

        // Consulto si se encuentra activo el script de la escena que se pausa
        if (UiPauseManager.instance != null)
        {
            if (UiPauseManager.instance.isPause) // Si el juego se encuentra en pausa
            {
                // Activo el panel de Pausa
                pauseCanvas.SetActive(true);
            }
        }
        else // Si no se encuentra activo, significa que no está en pausa
        {
            // Activo el panel de MainMenu
            mainMenuCanvas.SetActive(true);
        }
    }

    // Eventos de sliders
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
