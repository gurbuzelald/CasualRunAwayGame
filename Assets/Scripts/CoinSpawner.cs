using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinSpawner : MonoBehaviour
{
    [SerializeField] PlayerData playerData;
    private GameObject coinObject;
    private void Awake()
    {
        for (int i = 0; i < playerData.coinTransform.childCount; i++)
        {
            coinObject = Instantiate(playerData.coinObject, gameObject.transform);
            coinObject.transform.position = playerData.coinTransform.GetChild(i).position;
        }
    }
    void Update()
    {
        coinObject.transform.Rotate(0f, playerData.rotateCoin * Time.deltaTime, 0f);
    }
}
