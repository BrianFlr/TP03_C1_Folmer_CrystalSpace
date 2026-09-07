using UnityEngine;

public class Movement : MonoBehaviour
{
    public float Speed = 5.0f;
    [SerializeField] private KeyCode moveUp = KeyCode.W;
    [SerializeField] private KeyCode moveDown = KeyCode.S;

    private Rigidbody2D rb;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Start()
    {
        GetPlayersColorsValues();
    }

    private void FixedUpdate()
    {
        // Movimiento del jugador por posicionamiento
        if (Input.GetKey(moveUp))
        {
            rb.position += new Vector2(0, Speed * Time.fixedDeltaTime);
        }

        if (Input.GetKey(moveDown))
        {
            rb.position += new Vector2(0, -Speed * Time.fixedDeltaTime);
        }
    }

    // Función para obtener los valores de colores seteados en settings
    private void GetPlayersColorsValues()
    {
        Speed = PlayerPrefs.GetFloat("Player1Speed", Speed);
    }

}
