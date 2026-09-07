using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class UiSettingsSlidersColor : MonoBehaviour
{
    [Header("Sliders Color")]
    [SerializeField] private Slider sliderPlayer1Color;
    [SerializeField] private Slider sliderPlayer2Color;
    [SerializeField] private TMP_Text textPlayer1Color;
    [SerializeField] private TMP_Text textPlayer2Color;

    [Header("Players")]
    private SpriteRenderer Player1;
    private SpriteRenderer Player2;

    private void Awake()
    {
        sliderPlayer1Color.onValueChanged.AddListener(OnPlayer1ColorChanged);
        sliderPlayer2Color.onValueChanged.AddListener(OnPlayer2ColorChanged);
    }

    private void OnDestroy()
    {
        sliderPlayer1Color.onValueChanged.RemoveAllListeners();
        sliderPlayer2Color.onValueChanged.RemoveAllListeners();
    }

    // Eventos de sliders
    private void OnPlayer1ColorChanged(float value)
    {
        Player1.color = new Color(value, value, value);
        textPlayer1Color.text = value.ToString("F2");
    }
    private void OnPlayer2ColorChanged(float value)
    {
        Player2.color = new Color(value, value, value);
        textPlayer2Color.text = value.ToString("F2");
    }
}
