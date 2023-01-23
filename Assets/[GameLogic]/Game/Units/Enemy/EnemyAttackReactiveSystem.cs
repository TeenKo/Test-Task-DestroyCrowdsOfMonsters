using Entitas;
using System.Collections.Generic;

public class EnemyAttackReactiveSystem : ReactiveSystem<GameEntity>
{
    private Contexts _contexts;

    public EnemyAttackReactiveSystem(Contexts contexts) : base(contexts.game)
    {
        _contexts = contexts;
    }

    protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context)
    {
        return context.CreateCollector(GameMatcher.EnemyAttack.Added());
    }

    protected override bool Filter(GameEntity entity)
    {
        return entity.hasAttackRecharge == false;
    }

    protected override void Execute(List<GameEntity> entities)
    {
        foreach (var entity in entities)
        {
            entity.isAttackPlayer = true;
        }
    }
}