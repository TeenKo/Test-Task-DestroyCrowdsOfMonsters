using Entitas;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class EnemyLiveExecuteSystem : IExecuteSystem
{
    private Contexts _contexts;
    private IGroup<GameEntity> _enemyEntitiesGroup;
    private IGroup<GameEntity> _playerEntitiesGroup;
    private GameEntity _playerEntity;

    public EnemyLiveExecuteSystem(Contexts contexts)
    {
        _contexts = contexts;
        _enemyEntitiesGroup = contexts.game.GetGroup(GameMatcher.Enemy);
        _playerEntitiesGroup = contexts.game.GetGroup(GameMatcher.Player);
    }
    public void Execute()
    {
        if (_playerEntity == null) _playerEntity = _playerEntitiesGroup.GetEntities().FirstOrDefault();

        foreach (var enemyEntity in _enemyEntitiesGroup.GetEntities())
        {
            if (enemyEntity.enemyPoolState.value != EnemyPoolState.Live) continue;

            var playerTransform = _playerEntity.transform.value;
            var enemyTransform = enemyEntity.transform.value;
            var distance = GameTools.IsInFlatRange(enemyTransform.position, playerTransform.position, enemyEntity.attackDistance.value);

            var targetRotation = Quaternion.LookRotation(_playerEntity.transform.value.position - enemyEntity.transform.value.position);
            enemyTransform.rotation = Quaternion.Slerp(enemyTransform.rotation, targetRotation, 4 * Time.deltaTime);

            if (distance)
            {
                if (enemyEntity.isEnemyAttack == false)
                {
                    enemyEntity.isEnemyAttack = true;
                }
            }
            else
            {
                if (enemyEntity.isEnemyAttack == true)
                {
                    enemyEntity.isEnemyAttack = false;
                }

                enemyTransform.position += enemyTransform.forward * enemyEntity.speed.value * Time.deltaTime;
            }
        }
    }
}