using Core.Configs;
using UnityEngine;

[CreateAssetMenu(fileName = "GameConfig", menuName = "Configs/Game/GameConfig")]
public sealed class GameConfig : Config
{
    public const string PlayerDataKey = "playerData";
    public const string PoolParentName = "poolParent";

    [Header("Player Settings")]
    public PlayerView Player;
    public float PlayerSpeed;
    public float PlayerHealth;
    [Range(0,1)]public float PlayerDefeance;

    [Header("Camera Settings")]
    public Vector3 CameraOffset;
    public float SmoothSpeed;

    [Header("Ammo Settings")]
    public AmmoView Arrow;
    public int ArrowCount;
    public float ExplosionRadius;
    public float ExplosionDamage;

    [Header("Game Settings")]
    public int MaxEnemyCount;
}