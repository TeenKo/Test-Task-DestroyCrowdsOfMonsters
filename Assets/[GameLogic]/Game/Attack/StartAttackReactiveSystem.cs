using Entitas;
using System;
using System.Collections.Generic;
using System.Linq;

public class StartAttackReactiveSystem : ReactiveSystem<InputEntity>
{

    private Contexts _contexts;
    private IGroup<GameEntity> _ammoEntitiesGroup;
    private IGroup<GameEntity> _playerEntiesGroup;

    public StartAttackReactiveSystem(Contexts contexts) : base(contexts.input)
    {
        _contexts = contexts;
        _ammoEntitiesGroup = contexts.game.GetGroup(GameMatcher.Ammo);
        _playerEntiesGroup = contexts.game.GetGroup(GameMatcher.Player);
    }

    protected override ICollector<InputEntity> GetTrigger(IContext<InputEntity> context)
    {
        return context.CreateCollector(InputMatcher.TouchDownPosition.Added());
    }

    protected override bool Filter(InputEntity entity)
    {
        return _contexts.game.currentGameEntity.isGameStarted;
    }

    protected override void Execute(List<InputEntity> entities)
    {
        var entity = entities.FirstOrDefault();
        var playerEntity = _playerEntiesGroup.GetEntities().FirstOrDefault();

        var attackEntity = _contexts.game.CreateEntity();
        attackEntity.isStartAttack = true;
        attackEntity.AddEndPosition(entity.touchDownPosition.value);

        foreach (var ammoEntity in _ammoEntitiesGroup.GetEntities())
        {
            if (ammoEntity.ammoState.value == AmmoPoolState.Idle)
            {
                ammoEntity.ReplaceAmmoState(AmmoPoolState.Ready);
                ammoEntity.transform.value.position = playerEntity.ammoTransform.value.position;
                break;
            }
            else if (Array.IndexOf(_ammoEntitiesGroup.GetEntities().ToArray(), ammoEntity) == _ammoEntitiesGroup.GetEntities().Length - 1)
            {
                _contexts.game.CreateEntity().isCreateAmmo = true;
            }   
        }
    }
}