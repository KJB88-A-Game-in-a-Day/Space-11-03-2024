using UnityEngine;

[CreateAssetMenu(fileName = "newPlayerData", menuName = "Custom/PlayerData", order = 1)]
public class PlayerData : ScriptableObject
{
    [SerializeField] private float speedMod;
    public float SpeedMod => speedMod;
    [SerializeField] private Vector2 spawnPos;
    public Vector2 SpawnPos => spawnPos;
}
