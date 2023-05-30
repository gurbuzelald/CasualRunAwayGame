using System.Collections;
using System.Collections.Generic;
using Cinemachine;
using UnityEngine;

public class CameraManager : MonoBehaviour
{
    [SerializeField] GameObject playerSpawner;
    private void Update()
    {
        if (playerSpawner.transform.childCount > 0)
        {
            gameObject.GetComponent<CinemachineVirtualCamera>().m_Follow = playerSpawner.transform.GetChild(0).transform;
            gameObject.GetComponent<CinemachineVirtualCamera>().m_LookAt = playerSpawner.transform.GetChild(0).transform;
        }        
    }
}
