using Core.Configs;
using DesperateDevs.Utils;
using Entitas;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class MoveEnemyOutCameraReactiveSystem : ReactiveSystem<GameEntity>
{
    private Contexts _contexts;
    private IGroup<GameEntity> _enemyEntitiesGroup;
    private IGroup<GameEntity> _playerEntitiesGroup;
    private GameConfig _gameConfig;
    private PoolConfig _poolConfig;

    public MoveEnemyOutCameraReactiveSystem(Contexts contexts) : base(contexts.game)
    {
        _contexts = contexts;
        _enemyEntitiesGroup = contexts.game.GetGroup(GameMatcher.Enemy);
        _playerEntitiesGroup = contexts.game.GetGroup(GameMatcher.Player);
        _gameConfig = ConfigsCatalogsManager.GetConfig<GameConfig>();
        _poolConfig = ConfigsCatalogsManager.GetConfig<PoolConfig>();
    }

    protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context)
    {
        return context.CreateCollector(GameMatcher.MoveEnemyOutCamera.Added());
    }

    protected override bool Filter(GameEntity entity)
    {
        return true;
    }

    protected override void Execute(List<GameEntity> entities)
    {
        var randomIndex = _poolConfig.RandomEnemyType();

        foreach (var enemyEntity in _enemyEntitiesGroup.GetEntities())
        {
            if (enemyEntity.enemyPoolState.value == EnemyPoolState.Live || enemyEntity.enemyPoolState.value == EnemyPoolState.Death) continue;

            if ((int)enemyEntity.enemyType.value == randomIndex)
            {
                ChooseEnemy(enemyEntity);
                break;
            }
        }
    }

    private void ChooseEnemy(GameEntity enemyEntity)
    {
        var playerEntity = _playerEntitiesGroup.GetEntities().FirstOrDefault();

        //[0] = Left, [1] = Right, [2] = Back, [3] = Forward
        var spawnSide = Random.Range(0, 4);

        var offSet = playerEntity.distanceCameraFrusturms.value[spawnSide] > 0 ? 10f : -10f;

        var enemyPositionX = spawnSide > 1 ?
            Random.Range(playerEntity.distanceCameraFrusturms.value[0], playerEntity.distanceCameraFrusturms.value[1]) :
            playerEntity.distanceCameraFrusturms.value[spawnSide] + offSet;

        var enemyPositionZ = spawnSide < 1 ?
            Random.Range(playerEntity.distanceCameraFrusturms.value[2], playerEntity.distanceCameraFrusturms.value[3]) :
                        playerEntity.distanceCameraFrusturms.value[spawnSide] + offSet;

        enemyEntity.transform.value.position = new Vector3(enemyPositionX + playerEntity.transform.value.position.x, 0, enemyPositionZ + playerEntity.transform.value.position.z);

        enemyEntity.ReplaceEnemyPoolState(EnemyPoolState.Live);
    }
}