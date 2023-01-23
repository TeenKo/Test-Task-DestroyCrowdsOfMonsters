using Core.Configs;
using Entitas;
using System.Collections.Generic;

public class EnemyTakeDamage : ReactiveSystem<GameEntity>
{
    private Contexts _contexts;
    private GameConfig _gameConfig;

    public EnemyTakeDamage(Contexts contexts) : base(contexts.game)
    {
        _contexts = contexts;
        _gameConfig = ConfigsCatalogsManager.GetConfig<GameConfig>();
    }

    protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context)
    {
        return context.CreateCollector(GameMatcher.TakeDamage.Added());
    }

    protected override bool Filter(GameEntity entity)
    {
        return entity.isEnemy;
    }

    protected override void Execute(List<GameEntity> entities)
    {
        foreach (var entity in entities)
        {
            entity.ReplaceHealth(entity.health.value - _gameConfig.ExplosionDamage * entity.defeance.value);
        }
    }
}