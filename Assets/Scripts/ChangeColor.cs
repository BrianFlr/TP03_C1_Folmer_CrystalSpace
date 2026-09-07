using UnityEngine;

public class ChangeColor : MonoBehaviour
{ 
    [SerializeField] private KeyCode changeColor = KeyCode.R;

    private SpriteRenderer spriteRenderer;

    private void Awake()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }
    
    private void Start()
    {
        
    }

    private void Update()
    {   
        // Cambio de color del sprite
        if (Input.GetKeyUp(changeColor))
        {
            spriteRenderer.color = new Color(Random.value, Random.value, Random.value);
        }
    }

    // Función para obtener los valores de colores seteados
    private void GetColorsValues()
    {

    }
}
