using Core.Configs;
using Entitas;
using System.Collections.Generic;
using System.Linq;

public class AttackPlayerReactiveSystem : ReactiveSystem<GameEntity>
{
    private Contexts _contexts;
    private IGroup<GameEntity> _playerEntitiesGroup;
    private GameConfig _gameConfig;

    public AttackPlayerReactiveSystem(Contexts contexts) : base(contexts.game)
    {
        _contexts = contexts;
        _playerEntitiesGroup = contexts.game.GetGroup(GameMatcher.Player);
        _gameConfig = ConfigsCatalogsManager.GetConfig<GameConfig>();
    }

    protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context)
    {
        return context.CreateCollector(GameMatcher.AttackPlayer.Added());
    }

    protected override bool Filter(GameEntity entity)
    {
        return entity.isEnemyAttack;
    }

    protected override void Execute(List<GameEntity> entities)
    {
        var playerEntity = _playerEntitiesGroup.GetEntities().FirstOrDefault();

        foreach (var entity in entities)
        {
            playerEntity.ReplaceHealth(playerEntity.health.value - entity.damage.value * playerEntity.defeance.value);

            entity.ReplaceAttackRecharge(entity.attackSpeed.value);
        }
    }
}