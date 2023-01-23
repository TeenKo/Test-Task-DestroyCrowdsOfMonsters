using Core.Configs;
using UnityEngine;

[CreateAssetMenu(fileName = "GameConfigsCatalog", menuName = "Configs/Game/GameConfigsCatalog")]
public sealed class GameConfigsCatalog : ConfigsCatalog
{
    [SerializeField] private GameConfig gameConfig;
    [SerializeField] private GameLevelsConfig gameLevelsConfig;

    [SerializeField] private DebugLogConfig debugLogConfig;
    [SerializeField] private PoolConfig poolConfig;
}