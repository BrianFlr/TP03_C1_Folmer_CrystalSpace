using UnityEngine;

public class BallMovement : MonoBehaviour
{
    [SerializeField] private float ballSpeed = 20.0f;
    private Rigidbody2D ballRigidbody;

    private void Awake()
    {
        ballRigidbody = GetComponent<Rigidbody2D>();
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        ballRigidbody.AddForce(new Vector3(ballSpeed * Time.fixedDeltaTime, 0, 0));
    }

    // Update is called once per frame
    private void FixedUpdate()
    {
        
    }
}
