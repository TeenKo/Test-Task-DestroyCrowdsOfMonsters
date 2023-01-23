using Entitas;
using System.Collections.Generic;

public class EnemyCountReactiveSystem : ReactiveSystem<GameEntity>
{
    private Contexts _contexts;
    private IGroup<GameEntity> _enemyEntitiesGroup;

    public EnemyCountReactiveSystem(Contexts contexts) : base(contexts.game)
    {
        _contexts = contexts;
        _enemyEntitiesGroup = contexts.game.GetGroup(GameMatcher.Enemy);
    }

    protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context)
    {
        return context.CreateCollector(GameMatcher.EnemyPoolState.Added());
    }

    protected override bool Filter(GameEntity entity)
    {
        return true;
    }

    protected override void Execute(List<GameEntity> entities)
    {
        var enemyCount = 0;

        foreach (var enemyEntity in _enemyEntitiesGroup.GetEntities())
        {
            if (enemyEntity.enemyPoolState.value == EnemyPoolState.Live)
            {
                enemyCount++;
            }
        }

        _contexts.game.userDataEntity.ReplaceEnemyCount(enemyCount);
    }
}