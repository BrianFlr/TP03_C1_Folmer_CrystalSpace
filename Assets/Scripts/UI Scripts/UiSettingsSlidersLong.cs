using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class UiSettingsSlidersLong : MonoBehaviour
{
    [Header("Sliders Long")]
    [SerializeField] private Slider sliderPlayer1Long;
    [SerializeField] private Slider sliderPlayer2Long;
    [SerializeField] private TMP_Text textPlayer1Long;
    [SerializeField] private TMP_Text textPlayer2Long;

    [Header("Players")]
    private Movement Player1;
    private Movement Player2;


    private void Awake()
    {
        sliderPlayer1Long.onValueChanged.AddListener(OnPlayer1LongChanged);
        sliderPlayer2Long.onValueChanged.AddListener(OnPlayer2LongChanged);
    }

    private void OnDestroy()
    {
        sliderPlayer1Long.onValueChanged.RemoveAllListeners();
        sliderPlayer2Long.onValueChanged.RemoveAllListeners();
    }

    // Eventos de sliders
    private void OnPlayer1LongChanged(float value)
    {
        Player1.transform.localScale = new Vector3(1, value, 1);
        textPlayer1Long.text = value.ToString("F2");
    }

    private void OnPlayer2LongChanged(float value)
    {
        Player2.transform.localScale = new Vector3(1, value, 1);
        textPlayer2Long.text = value.ToString("F2");
    }
}
