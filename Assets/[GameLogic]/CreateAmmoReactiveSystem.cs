using Core.Configs;
using Entitas;
using System.Collections.Generic;
using UnityEngine;

public class CreateAmmoReactiveSystem : ReactiveSystem<GameEntity>
{
    private Contexts _contexts;
    private GameConfig _gameConfig;

    public CreateAmmoReactiveSystem(Contexts contexts) : base(contexts.game)
    {
        _contexts = contexts;
        _gameConfig = ConfigsCatalogsManager.GetConfig<GameConfig>();
    }

    protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context)
    {
        return context.CreateCollector(GameMatcher.CreateAmmo.Added());
    }

    protected override bool Filter(GameEntity entity)
    {
        return true;
    }

    protected override void Execute(List<GameEntity> entities)
    {
        var poolParentObject = GameObject.Find(GameConfig.PoolParentName);

        for (int i = 0; i < _gameConfig.ArrowCount; i++)
        {
            var ammoView = Object.Instantiate(_gameConfig.Arrow, Vector3.zero, Quaternion.identity, poolParentObject.transform);
            var arrowEntity = _contexts.game.CreateEntity();
            arrowEntity.AddIndex(poolParentObject.transform.childCount);
            ammoView.Init(arrowEntity);
        }
    }
}