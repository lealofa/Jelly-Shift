using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BotSpawner : MonoBehaviour
{
    public GameObject botPrefab;
    public int botCount = 10;

    void Start()
    {
        SpawnBots();
    }

    void SpawnBots()
    {
        for (int i = 0; i < botCount; i++)
        {
            Vector3 randomPosition = new Vector3(Random.Range(-194, 194f), 0.5f, Random.Range(-151, 151f));
            Instantiate(botPrefab, randomPosition, Quaternion.identity);
        }
    }
}
