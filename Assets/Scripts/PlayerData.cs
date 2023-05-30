using UnityEngine;
[CreateAssetMenu(fileName = "NewPlayerData", menuName = "PlayerData")]
public class PlayerData : ScriptableObject
{
    public GameObject playerObject;
    public GameObject coinObject;

    public Transform coinTransform;

    public int jumpCounter;
    public float rotateCoin;
}
