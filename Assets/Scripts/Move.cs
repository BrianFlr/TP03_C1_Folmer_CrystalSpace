using UnityEngine;

public class Move : MonoBehaviour
{
    public float Speed = 5.0f;
    [SerializeField] private KeyCode moveUp = KeyCode.W;
    [SerializeField] private KeyCode moveDown = KeyCode.S;
    //[SerializeField] private KeyCode moveLeft = KeyCode.A;
    //[SerializeField] private KeyCode moveRight = KeyCode.D;

    private bool isContinuous;

    private Rigidbody2D rigidBody;

    private void Awake()
    {
        rigidBody = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate() // Fisicas
    {
        if (isContinuous)
        {
            // Movimiento continuo por impulso de fuerza
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

            // Limitar la velocidad de empuje para que no siga aumentando infinitamente
            //if (rigidBody.linearVelocity.y > 5)
            //{
            //    rigidBody.linearVelocity = new Vector2(rigidBody.linearVelocity.x, 5);
            //}
        }
        else
        {
            // Movimiento normal por posicionamiento
            if (Input.GetKey(moveUp))
            {
                rigidBody.position += new Vector2(0, Speed * Time.fixedDeltaTime);
            }

            if (Input.GetKey(moveDown))
            {
                rigidBody.position += new Vector2(0, -Speed * Time.fixedDeltaTime);
            }

            //if (Input.GetKey(moveLeft))
            //{
            //    rigidBody.position = new Vector3(-Speed * Time.fixedDeltaTime, 0, 0);
            //}

            //if (Input.GetKey(moveRight))
            //{
            //    rigidBody.position = new Vector3(-Speed * Time.fixedDeltaTime, 0, 0);
            //}
        }
    }
}
