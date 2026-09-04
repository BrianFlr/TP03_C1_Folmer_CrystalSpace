using UnityEngine;

public class Movement : MonoBehaviour
{
    [Header ("Movimiento")]
    public float Speed = 5.0f;
    [SerializeField] private KeyCode moveUp = KeyCode.W;
    [SerializeField] private KeyCode moveDown = KeyCode.S;
    [SerializeField] private KeyCode moveLeft = KeyCode.A;
    [SerializeField] private KeyCode moveRight = KeyCode.D;

    [Header("Rotacion")]
    [SerializeField] private KeyCode rotateLeft = KeyCode.Q;
    [SerializeField] private KeyCode rotateRight = KeyCode.E;

    [Header("Color")]
    [SerializeField] private float rotateSpeed = 10.0f;
    [SerializeField] private KeyCode changeColor = KeyCode.R;

    private SpriteRenderer spriteRenderer;
    private void Awake()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        if (Time.timeScale == 1) // For isPause (Temporal)
        {
            // Movimiento del sprite
            if (Input.GetKey(moveUp))
            {
                transform.position += new Vector3(0, Speed * Time.deltaTime, 0);
            }

            if (Input.GetKey(moveDown))
            {
                transform.position += new Vector3(0, -Speed * Time.deltaTime, 0);
            }

            if (Input.GetKey(moveLeft))
            {
                transform.position += new Vector3(-Speed * Time.deltaTime, 0, 0);
            }

            if (Input.GetKey(moveRight))
            {
                transform.position += new Vector3(Speed * Time.deltaTime, 0, 0);
            }

            // Rotacion del sprite
            if (Input.GetKeyDown(rotateLeft))
            {
                //transform.Rotate(Vector3.forward * rotateSpeed);
                transform.Rotate(0, 0, rotateSpeed);
            }

            if (Input.GetKeyDown(rotateRight))
            {
                //transform.Rotate(Vector3.forward * -rotateSpeed);
                transform.Rotate(0, 0, -rotateSpeed);
            }

            // Cambio de color del sprite
            if (Input.GetKeyUp(changeColor))
            {
                spriteRenderer.color = new Color(Random.value, Random.value, Random.value);
            }
        }
        
    }
}
