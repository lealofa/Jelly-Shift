using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodSpawner : MonoBehaviour
{
    public GameObject foodPreFab;
    public int foodCount = 50;
    void Start()
    {
        SpawnFood();
    }

    void SpawnFood()
    {
        for (int i = 0; i<foodCount; i++)
        {
            Vector3 randomPos = new Vector3(Random.Range(-194, 194), 0.5f, Random.Range(-151, 151));
            Instantiate(foodPreFab, randomPos, Quaternion.identity);
        }
    }

}
