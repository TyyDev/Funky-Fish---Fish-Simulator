using System.Collections;
using System.Collections.Generic;
using Unity.Burst.CompilerServices;
using UnityEngine;

public class BigFish : MonoBehaviour
{
    public Rigidbody2D rb;
    public GameObject fish;
    public float speed = 15.0f;
    private Transform target;
    public SpriteRenderer spriteRenderer;
    private Vector2 movement;
    private float timeLeft;
    public float maxSpeed = 2f;
    void Awake()
    {

        target = fish.transform;
        rb = GetComponent<Rigidbody2D>();
        spriteRenderer = GetComponent<SpriteRenderer>();
    }


    void Update()
    {
        var step = speed * Time.deltaTime;
        transform.position = Vector3.MoveTowards(transform.position, target.position, step);

        if (Vector3.Distance(transform.position, target.position) < 0.5f)
        {
            target.position *= -1.0f;
        }

        timeLeft -= Time.deltaTime;
        if (timeLeft <= 0)
        {
            movement = new Vector2(Random.Range(-0.5f, 0.5f), Random.Range(-1f, 0.5f)).normalized;

          
        }
    }


    public void OnColisionEnter(GameObject fish)
    {
        Debug.Log("I'm eating!");
       
    }


    private void FixedUpdate()
    {
        rb.AddForce(movement * maxSpeed);
    }
}
