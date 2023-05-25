using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoadCreator : MonoBehaviour
{
    [SerializeField] private GameObject roadPrefab;
    [SerializeField] private float distance;
    private void Start()
    {
        CreateRoad();
    }
    private void CreateRoad()
    {
        float Zposition = 0;
        for(int i = 0; i < 50; i++)
        {
            GameObject roadInstance = Instantiate(roadPrefab);
            roadInstance.transform.position = new Vector3(0f, 0f, Zposition);
            Zposition += distance;
        }
        

    }
}
