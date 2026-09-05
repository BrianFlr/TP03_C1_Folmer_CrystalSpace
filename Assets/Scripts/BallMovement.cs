using UnityEngine;

public class BallMovement : MonoBehaviour
{
    [SerializeField] private float ballSpeed = 200.0f;
    private Rigidbody2D ballRigidbody;

    private void Awake()
    {
        ballRigidbody = GetComponent<Rigidbody2D>();
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    private void FixedUpdate()
    {
        ballRigidbody.AddForce(new Vector3(ballSpeed * Time.fixedDeltaTime, 0, 0));
    }
}
