using UnityEngine;

[CreateAssetMenu(fileName = "newPlayerData", menuName = "Custom/PlayerData", order = 1)]
public class PlayerData : ScriptableObject
{
    [Header("Modifiers")]
    [SerializeField] private float speedMod = 5.0f;
    public float SpeedMod => speedMod;

    [Header("Spawning")]
    [SerializeField] private Vector2 spawnPos;
    public Vector2 SpawnPos => spawnPos;

    [Header("Bounds")]
    [SerializeField] private float yBoundMax = -4.0f;
    [SerializeField] private float yBoundMin = -4.75f;
    public float YBoundMax => yBoundMax;
    public float YBoundMin => yBoundMin;

}
