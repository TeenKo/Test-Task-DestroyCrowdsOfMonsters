using Core.Configs;
using Entitas;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class EnemyIdleStateReactiveSystem : ReactiveSystem<GameEntity>
{
    private Contexts _contexts;
    private PoolConfig _poolConfig;

    public EnemyIdleStateReactiveSystem(Contexts contexts) : base(contexts.game)
    {
        _contexts = contexts;
        _poolConfig = ConfigsCatalogsManager.GetConfig<PoolConfig>();
    }

    protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context)
    {
        return context.CreateCollector(GameMatcher.EnemyPoolState.Added());
    }

    protected override bool Filter(GameEntity entity)
    {
        return entity.enemyPoolState.value == EnemyPoolState.Idle;
    }

    protected override void Execute(List<GameEntity> entities)
    {
        var health = 0f;

        foreach (var entity in entities)
        {
            foreach (var enemy in _poolConfig.Enemies)
            {
                if (entity.enemyType.value == enemy.EnemyType)
                {
                    health = enemy.Health;
                    break;
                }
            }

            entity.transform.value.position = Vector3.one * 10000f;
            entity.transform.value.localScale = Vector3.one;
            entity.ReplaceHealth(health);
        }
    }
}