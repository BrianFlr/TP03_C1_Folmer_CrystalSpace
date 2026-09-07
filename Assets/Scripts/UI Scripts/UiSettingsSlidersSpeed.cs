using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class UiSettingsSlidersSpeed : MonoBehaviour
{
    [Header("Sliders Speed")]
    [SerializeField] private Slider sliderPlayer1Speed;
    [SerializeField] private Slider sliderPlayer2Speed;
    [SerializeField] private TMP_Text textPlayer1Speed;
    [SerializeField] private TMP_Text textPlayer2Speed;

    [Header("Players")]
    [SerializeField] private Movement Player1;
    [SerializeField] private Movement Player2;


    private void Awake()
    {
        sliderPlayer1Speed.onValueChanged.AddListener(OnPlayer1SpeedChanged);
        sliderPlayer2Speed.onValueChanged.AddListener(OnPlayer2SpeedChanged);
    }

    private void OnDestroy()
    {
        sliderPlayer1Speed.onValueChanged.RemoveAllListeners();
        sliderPlayer2Speed.onValueChanged.RemoveAllListeners();
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
}
