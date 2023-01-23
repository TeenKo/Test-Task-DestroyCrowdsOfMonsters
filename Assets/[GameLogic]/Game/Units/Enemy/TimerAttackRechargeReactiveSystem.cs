using Entitas;
using System.Collections.Generic;
using UnityEngine;

public class TimerAttackRechargeReactiveSystem : ReactiveSystem<GameEntity>
{
    private Contexts _contexts;

    public TimerAttackRechargeReactiveSystem(Contexts contexts) : base(contexts.game)
    {
        _contexts = contexts;
    }

    protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context)
    {
        return context.CreateCollector(GameMatcher.AttackRecharge.Added());
    }

    protected override bool Filter(GameEntity entity)
    {
        return entity.hasAttackRecharge;
    }

    protected override void Execute(List<GameEntity> entities)
    {
        foreach (var entity in entities)
        {
            var timeValue = entity.attackRecharge.value - Time.deltaTime;

            if (timeValue <= 0)
            {
                entity.isAttackPlayer = true;
                entity.RemoveAttackRecharge();
            }
            else
            {
                entity.ReplaceAttackRecharge(timeValue);
            }
        }
    }
}