using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoadCreator : MonoBehaviour
{
    [SerializeField] private GameObject roadPrefab;
    [SerializeField] private float distance;
    [SerializeField] private int roadPartCount = 100;
    [SerializeField] private EnvironmentPrefabs prefabs;
    [SerializeField] private EnvironmentConfig config;

    private void Start()
    {
        CreateRoad();
        CreateHouses();
    }

    private void CreateRoad()
    {
        float Zposition = 0;
        for(int i = 0; i < roadPartCount; i++)
        {
            Vector3 position = new Vector3(0f, 0f, Zposition);
            
            GameObject roadInstance = Instantiate(prefabs.roadPrefabs[1], position, Quaternion.identity, transform);
            //roadInstance.transform.SetParent(transform); // vtor nacin da se setira parent na nekoj objekt
            Zposition += distance;
        }
    }

    private void CreateHouses()
    {
        float Zposition = 0;
        for (int i = 0; i < roadPartCount; i++)
        {
            Instantiate(prefabs.GetRandomHouse(), new Vector3(config.HousesOnLeftStartPos.x, 0f, Zposition), Quaternion.identity, transform);
            Instantiate(prefabs.GetRandomHouse(), new Vector3(config.HousesOnRightStartPos.x, 0f, Zposition), Quaternion.identity, transform);
            //roadInstance.transform.SetParent(transform); // vtor nacin da se setira parent na nekoj objekt
            Zposition += 30;
        }
    }

    // so korutina
    //private void Start()
    //{
    //    StartCoroutine(CreateRoad());
    //}

    //private IEnumerator CreateRoad()
    //{
    //    float Zposition = 0;
    //    for (int i = 0; i < 50; i++)
    //    {
    //        Vector3 position = new Vector3(0f, 0f, Zposition);
    //        GameObject roadInstance = Instantiate(roadPrefab, position, Quaternion.identity, transform);
    //        //roadInstance.transform.SetParent(transform); // vtor nacin da se setira parent na nekoj objekt
    //        Zposition += distance;
    //        yield return new WaitForSeconds(0.2f);
    //    }
    //}
}
