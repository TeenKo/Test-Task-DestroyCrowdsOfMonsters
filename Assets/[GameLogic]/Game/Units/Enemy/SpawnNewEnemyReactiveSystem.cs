using Core.Configs;
using Entitas;
using System.Collections.Generic;

public class SpawnNewEnemyReactiveSystem : ReactiveSystem<GameEntity>
{
    private Contexts _contexts;
    private GameConfig _gameConfig;

    public SpawnNewEnemyReactiveSystem(Contexts contexts) : base(contexts.game)
    {
        _contexts = contexts;
        _gameConfig = ConfigsCatalogsManager.GetConfig<GameConfig>();
    }

    protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context)
    {
        return context.CreateCollector(GameMatcher.EnemyCount.Added());
    }

    protected override bool Filter(GameEntity entity)
    {
        return entity.enemyCount.value < _gameConfig.MaxEnemyCount && _contexts.game.currentGameEntity.isGameStarted;
    }

    protected override void Execute(List<GameEntity> entities)
    {
        _contexts.game.CreateEntity().requestMoveEnemyOutCamera = true;
    }
}