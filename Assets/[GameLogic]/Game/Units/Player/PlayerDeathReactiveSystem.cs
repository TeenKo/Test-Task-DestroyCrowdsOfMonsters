using Entitas;
using System.Collections.Generic;
using System.Linq;

public class PlayerDeathReactiveSystem : ReactiveSystem<GameEntity>
{
    private Contexts _contexts;

    public PlayerDeathReactiveSystem(Contexts contexts) : base(contexts.game)
    {
        _contexts = contexts;
    }

    protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context)
    {
        return context.CreateCollector(GameMatcher.Health.Added());
    }

    protected override bool Filter(GameEntity entity)
    {
        return entity.isPlayer;
    }

    protected override void Execute(List<GameEntity> entities)
    {
        var entity = entities.FirstOrDefault();

        if (entity.health.value <= 0)
        {
            _contexts.state.appStateEntity.transitionDefeat = true;
        }
    }
}