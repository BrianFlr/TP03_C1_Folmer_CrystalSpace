using UnityEngine;

public class Move : MonoBehaviour
{
    public float Speed = 5.0f;
    [SerializeField] private KeyCode moveUp = KeyCode.W;
    [SerializeField] private KeyCode moveDown = KeyCode.S;
    //[SerializeField] private KeyCode moveLeft = KeyCode.A;
    //[SerializeField] private KeyCode moveRight = KeyCode.D;

    private bool isContinuous;

    private Rigidbody2D rb;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate() // Fisicas
    {
        if (isContinuous)
        {
            // Movimiento continuo por impulso de fuerza
            if (Input.GetKey(moveUp))
            {
                rb.AddForce(new Vector3(0, Speed * Time.fixedDeltaTime, 0));
            }

            if (Input.GetKey(moveDown))
            {
                rb.AddForce(new Vector3(0, -Speed * Time.fixedDeltaTime, 0));
            }

            //if (Input.GetKey(moveLeft))
            //{
            //    rb.AddForce(new Vector3(-Speed * Time.fixedDeltaTime, 0, 0));
            //}

            //if (Input.GetKey(moveRight))
            //{
            //    rb.AddForce(new Vector3(-Speed * Time.fixedDeltaTime, 0, 0));
            //}

            // Limitar la velocidad de empuje para que no siga aumentando infinitamente
            //if (rb.linearVelocity.y > 5)
            //{
            //    rb.linearVelocity = new Vector2(rigidBody.linearVelocity.x, 5);
            //}
        }
        else
        {
            // Movimiento normal por posicionamiento
            if (Input.GetKey(moveUp))
            {
                rb.position += new Vector2(0, Speed * Time.fixedDeltaTime);
            }

            if (Input.GetKey(moveDown))
            {
                rb.position += new Vector2(0, -Speed * Time.fixedDeltaTime);
            }

            //if (Input.GetKey(moveLeft))
            //{
            //    rb.position = new Vector3(-Speed * Time.fixedDeltaTime, 0, 0);
            //}

            //if (Input.GetKey(moveRight))
            //{
            //    rb.position = new Vector3(-Speed * Time.fixedDeltaTime, 0, 0);
            //}
        }
    }
}
