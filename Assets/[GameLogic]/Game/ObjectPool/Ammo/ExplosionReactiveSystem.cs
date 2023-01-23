using Core.Configs;
using DG.Tweening;
using Entitas;
using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using static UnityEngine.EventSystems.EventTrigger;

public class ExplosionReactiveSystem : ReactiveSystem<GameEntity>
{
    private Contexts _contexts;
    private IGroup<GameEntity> _enemyEntitiesGroup;
    private GameConfig _gameCofig;
    
    public ExplosionReactiveSystem(Contexts contexts) : base(contexts.game)
    {
        _contexts = contexts;
        _enemyEntitiesGroup = _contexts.game.GetGroup(GameMatcher.Enemy);
        _gameCofig = ConfigsCatalogsManager.GetConfig<GameConfig>();
    }

    protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context)
    {
        return context.CreateCollector(GameMatcher.Explosion.Added());
    }

    protected override bool Filter(GameEntity entity)
    {
        return true;
    }

    protected override void Execute(List<GameEntity> entities)
    {
        var entity = entities.FirstOrDefault();

        foreach (var enemy in _enemyEntitiesGroup)
        {
            var takeDamage = GameTools.IsInFlatRange(entity.transform.value.position, enemy.transform.value.position, _gameCofig.ExplosionRadius);

            if (takeDamage && enemy.health.value > 0)
            {
                enemy.isTakeDamage = true;
            }
        }

        TweenTimer(entity);
    }

    private void TweenTimer(GameEntity entity)
    {
        var value = 0f;

        DOTween.To(()=> value, x => value = x, 1f, 0.5f).OnComplete(()=> entity.ReplaceAmmoState(AmmoPoolState.Idle));
    }
}