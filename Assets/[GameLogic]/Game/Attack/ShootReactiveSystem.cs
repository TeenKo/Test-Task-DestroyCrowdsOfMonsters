using Entitas;
using System.Collections.Generic;
using System.Linq;

public class ShootReactiveSystem : ReactiveSystem<GameEntity>
{
    private Contexts _contexts;
    private IGroup<GameEntity> _ammoEntitiesGroup;

    public ShootReactiveSystem(Contexts contexts) : base(contexts.game)
    {
        _contexts = contexts;
        _ammoEntitiesGroup = contexts.game.GetGroup(GameMatcher.Ammo);
    }

    protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context)
    {
        return context.CreateCollector(GameMatcher.StartAttack.Added());
    }

    protected override bool Filter(GameEntity entity)
    {
        return true;
    }

    protected override void Execute(List<GameEntity> entities)
    {
        var entity = entities.FirstOrDefault();
        var controlEntity = _contexts.input.mouseContolEntity;

        foreach (var ammoEntity in _ammoEntitiesGroup.GetEntities())
        {
            if (ammoEntity.ammoState.value == AmmoPoolState.Ready)
            {
                ammoEntity.ReplaceEndPosition(controlEntity.cameraRay.value.GetPoint(controlEntity.cameraRayDistance.value - 0.5f));
                ammoEntity.ReplaceAmmoState(AmmoPoolState.Busy);
            }
        }
    }
}