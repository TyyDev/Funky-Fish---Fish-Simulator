using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class Food : MonoBehaviour
{
    public float speed = 1.0f;
    public Collider2D fish;
    public bool foodTrigger = false;



    



        private void OnTriggerEnter2D(Collider2D fish)
        {
           foodTrigger = true;
            Debug.Log("Hit!");
        }


  
}
