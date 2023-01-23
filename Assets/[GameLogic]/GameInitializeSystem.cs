using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Entitas;
using Core.Configs;

public class GameInitializeSystem : IInitializeSystem
{
    private Contexts _contexts;
    private GameConfig _gameConfig;
    private PoolConfig _poolConfig;

    public GameInitializeSystem(Contexts contexts)
    {
        _contexts = contexts;
        _gameConfig = ConfigsCatalogsManager.GetConfig<GameConfig>();
        _poolConfig = ConfigsCatalogsManager.GetConfig<PoolConfig>();
    }

    public void Initialize()
    {
        InitPlayer();
        InitCamera();
        InitAmmo();
        InitEnemy();
    }

    private void InitPlayer()
    {
        var playerSpawnView = Object.FindObjectOfType<PlayerSpawnView>(includeInactive: true);
        var playerSpawnEntity = _contexts.game.CreateEntity();
        playerSpawnView.Init(playerSpawnEntity);
    }

    private void InitCamera()
    {
        var cameraView = Object.FindObjectOfType<CameraView>(includeInactive: true);
        cameraView.transform.position = _gameConfig.CameraOffset;
        var mainCameraEntity = Contexts.sharedInstance.game.CreateEntity();
        cameraView.Init(mainCameraEntity);
    }

    private void InitAmmo()
    {
        Debug.Log("InitAmmo");
        var poolParent = new GameObject();
        poolParent.name = $"{GameConfig.PoolParentName}";

        for (int i = 0; i < _gameConfig.ArrowCount; i++)
        {
            var ammoView = Object.Instantiate(_gameConfig.Arrow, Vector3.zero, Quaternion.identity, poolParent.transform);
            var arrowEntity = _contexts.game.CreateEntity();
            arrowEntity.AddIndex(i);
            ammoView.Init(arrowEntity);
        }
    }

    private void InitEnemy()
    {
        Debug.Log("InitEnemy");
        foreach (var enemy in _poolConfig.Enemies)
        {
            var poolParent = new GameObject();
            poolParent.name = $"{enemy.EnemyType}";

            for (int i = 0; i < enemy.EnemyCount; i++)
            {
                var enemyView = Object.Instantiate(enemy.EnemyView, Vector3.one * 1000, Quaternion.identity, poolParent.transform);
                var enemyEntity = _contexts.game.CreateEntity();
                enemyEntity.AddIndex(i);
                enemyEntity.AddEnemyType(enemy.EnemyType);
                enemyView.Init(enemyEntity);
            }
        }
    }
}
