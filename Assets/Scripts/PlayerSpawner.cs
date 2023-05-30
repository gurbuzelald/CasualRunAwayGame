using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSpawner : MonoBehaviour
{
    [SerializeField] private PlayerData playerData;
    private void Awake()
    {
        GameObject playerObject = Instantiate(playerData.playerObject, gameObject.transform);
    }
}
