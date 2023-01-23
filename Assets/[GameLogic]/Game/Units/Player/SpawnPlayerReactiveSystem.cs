using Core.Configs;
using Entitas;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPlayerReactiveSystem : ReactiveSystem<GameEntity>
{
    private Contexts _contexts;
    private GameConfig _gameConfig;

    public SpawnPlayerReactiveSystem(Contexts contexts) : base(contexts.game)
    {
        _contexts = contexts;
        _gameConfig = ConfigsCatalogsManager.GetConfig<GameConfig>();
    }

    protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context)
    {
        return context.CreateCollector(GameMatcher.PlayerSpawnPoint.Added());
    }

    protected override bool Filter(GameEntity entity)
    {
        return true;
    }

    protected override void Execute(List<GameEntity> entities)
    {
        foreach (var entity in entities)
        {
            var transform = entity.transform.value.transform;
            var spawnPosition = new Vector3(transform.position.x, transform.position.y + 1f, transform.position.z);
            var playerView = Object.Instantiate(_gameConfig.Player, spawnPosition, Quaternion.identity);
            var playerEntity = _contexts.game.CreateEntity();
            playerView.Init(playerEntity);
            break;
        }
    }
}