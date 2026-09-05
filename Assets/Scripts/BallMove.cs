using System;
using UnityEngine;

public class BallMove : MonoBehaviour
{
    [SerializeField] private float ballSpeed = 1.0f;
    private Rigidbody2D rbBall;

    private void Awake()
    {
        rbBall = GetComponent<Rigidbody2D>();
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rbBall.AddForce(new Vector3(ballSpeed * Time.fixedDeltaTime, 0, 0));
    }

    // Agrego velocidad con el tiempo
    private void FixedUpdate()
    {
        ballSpeed += 1;
    }

    // Agrego velocidad cada vez que choca la pelota
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("SEE");
        rbBall.AddForce(new Vector2(rbBall.position.x * ballSpeed, rbBall.position.y * ballSpeed));
    }
}
