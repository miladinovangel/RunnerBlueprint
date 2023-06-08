using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "environment", menuName = "SO/EnvSO", order = 1)]
public class EnvironmentPrefabs : ScriptableObject
{
    public GameObject[] housePrefabs;
    public GameObject[] roadPrefabs;
    public GameObject[] environmentPrefabs;
    public GameObject[] treePrefabs;
    public GameObject[] plantPrefabs;

    // sakame da sortirame nekoj podatok
    public void Test()
    {
        Debug.Log("test");
    }

    public GameObject GetRandomHouse()
    {
        int randomIndex = Random.Range(0, housePrefabs.Length);
        return housePrefabs[randomIndex];
    }
}
