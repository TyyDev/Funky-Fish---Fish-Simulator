using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.U2D;
using static UnityEngine.GraphicsBuffer;

public class FishMovement : MonoBehaviour
{
    public Rigidbody2D rb;
    public float accelerationTime = 5f;
    public float maxSpeed = 3f;
    public SpriteRenderer spriteRenderer; 
    private Vector2 movement;
    private float timeLeft;
    public float speed = 15.0f;


    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        spriteRenderer = GetComponent<SpriteRenderer>(); 
    }

    void Update()
    {

        timeLeft -= Time.deltaTime;
        if (timeLeft <= 0)
        {
            movement = new Vector2(Random.Range(-0.5f, 0.5f), Random.Range(-0.5f, 0.5f)).normalized;
            timeLeft += accelerationTime;

            if (movement.x > 0) 
                spriteRenderer.flipX = false; 
            else if (movement.x < 0) 
                spriteRenderer.flipX = true; 
           
        }
    }

    private void FixedUpdate()
    {
        rb.AddForce(movement * maxSpeed);
    }
}
