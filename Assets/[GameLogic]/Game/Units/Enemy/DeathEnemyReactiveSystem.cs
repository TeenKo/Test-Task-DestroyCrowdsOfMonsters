using Entitas;
using System.Collections.Generic;

public class DeathEnemyReactiveSystem : ReactiveSystem<GameEntity>
{
    private Contexts _contexts;

    public DeathEnemyReactiveSystem(Contexts contexts) : base(contexts.game)
    {
        _contexts = contexts;
    }

    protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context)
    {
        return context.CreateCollector(GameMatcher.Health);
    }

    protected override bool Filter(GameEntity entity)
    {
        return entity.isEnemy;
    }

    protected override void Execute(List<GameEntity> entities)
    {
        foreach (var entity in entities)
        {
            if (entity.health.value <= 0)
            {
                entity.isDeath = true;
                _contexts.game.userDataEntity.ReplaceEnemyDeathCount(_contexts.game.userDataEntity.enemyDeathCount.value + 1);
            }
        }
    }
}