using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField] private GameObject enemyPrefab;

    private void Start()
    {
        InvokeRepeating("SpawnEnemy", 1, 0.5f);
    }

    private void SpawnEnemy()
    {
        Instantiate(enemyPrefab, new Vector3(Random.Range(-2f, 2f), 0f, Random.Range(-2f, 2f)), Quaternion.identity);
    }
}
