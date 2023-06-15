using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class CameraController : MonoBehaviour
{
    public static CameraController Instance;

    [SerializeField] private CinemachineVirtualCamera cam1;
    [SerializeField] private CinemachineVirtualCamera cam2;
    private void Awake()
    {
        Instance = this;
    }
    public void SwitchToCamera1()
    {
        cam2.gameObject.SetActive(false);
        cam1.gameObject.SetActive(true);
    }

    public void SwitchToCamera2()
    {
        cam1.gameObject.SetActive(false);
        cam2.gameObject.SetActive(true);
    }
}
