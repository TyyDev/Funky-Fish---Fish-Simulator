using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject food;
    public Vector2 minposition;
    public Vector2 maxposition;
    public GameObject fish;




    public void spawnFood()
    {
        Vector2 randomPosition = new Vector2(
       Random.Range(minposition.x, maxposition.x),
       Random.Range(minposition.y, maxposition.y)
       );
        Instantiate(food, randomPosition, Quaternion.identity);

    }

    public void spawnFish()
    {
        Vector2 randomPosition = new Vector2(
       Random.Range(minposition.x, maxposition.x),
       Random.Range(minposition.y, maxposition.y)
       );
        Instantiate(fish, randomPosition, Quaternion.identity);

    }


}





