using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{

    [SerializeField] private float initialVelocity = 4f;
    [SerializeField] private float VelocityMultiplier = 1.1f;

    private Rigidbody2D ballRb;

    void Start()
    {
        ballRb = GetComponent<Rigidbody2D>();
        Launch();
    }


    private void Launch()

    {
        float xVelocity = Random.Range(0, 2) == 0 ? 1 : -1;
        float yVelocity = Random.Range(0, 2) == 0 ? 1 : -1;
        ballRb.velocity = new Vector2(xVelocity, yVelocity) * initialVelocity;
    }
    private void onCollisionEnter2D(Collision2D collision)
    {
        ballRb.velocity *= VelocityMultiplier;
    }
    void Update()
    {

    }
}