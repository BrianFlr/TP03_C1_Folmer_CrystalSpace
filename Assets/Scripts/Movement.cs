using UnityEngine;

public class Movement : MonoBehaviour
{
    [Header ("Movimiento")]
    public float Speed = 15.0f;
    [SerializeField] private KeyCode moveUp = KeyCode.W;
    [SerializeField] private KeyCode moveDown = KeyCode.S;
    //[SerializeField] private KeyCode moveLeft = KeyCode.A;
    //[SerializeField] private KeyCode moveRight = KeyCode.D;

    [Header("Rotacion")]
    [SerializeField] private KeyCode rotateLeft = KeyCode.Q;
    [SerializeField] private KeyCode rotateRight = KeyCode.E;

    [Header("Color")]
    [SerializeField] private float rotateSpeed = 10.0f;
    [SerializeField] private KeyCode changeColor = KeyCode.R;

    private Rigidbody2D rigidBody;
    private SpriteRenderer spriteRenderer;

    private void Awake()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        rigidBody = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        if (Time.timeScale == 1) // For isPause (Temporal)
        {
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

    private void FixedUpdate() // Fisicas
    {
        // Movimiento
        if (Input.GetKey(moveUp))
        {
            rigidBody.AddForce(new Vector3(0, Speed * Time.fixedDeltaTime, 0));
        }
    
        if (Input.GetKey(moveDown))
        {
            rigidBody.AddForce(new Vector3(0, -Speed * Time.fixedDeltaTime, 0));
        }
    
        //if (Input.GetKey(moveLeft))
        //{
        //    rigidBody.AddForce(new Vector3(-Speed * Time.fixedDeltaTime, 0, 0));
        //}
    
        //if (Input.GetKey(moveRight))
        //{
        //    rigidBody.AddForce(new Vector3(-Speed * Time.fixedDeltaTime, 0, 0));
        //}

    }
}
