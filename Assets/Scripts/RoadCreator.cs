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
            Vector3 position = new Vector3(0f, 0f, Zposition);
            GameObject roadInstance = Instantiate(roadPrefab, position, Quaternion.identity, transform);
            //roadInstance.transform.SetParent(transform); // vtor nacin da se setira parent na nekoj objekt
            Zposition += distance;
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
