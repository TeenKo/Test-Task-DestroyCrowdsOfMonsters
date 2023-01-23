using System.Collections.Generic;
using Entitas;

namespace Core.ApplicationStates
{
    public sealed class DefeatTransitionListenerSystem : ReactiveSystem<StateEntity>
    {
        private readonly GameContext _gameContext;
        private readonly IGroup<GameEntity> _enemyEntitiesGroup;
        private readonly IGroup<GameEntity> _playerEntitiesGroup;

        public DefeatTransitionListenerSystem(StateContext stateContext, GameContext gameContext) : base(stateContext)
        {
            _gameContext = gameContext;
            _enemyEntitiesGroup = _gameContext.GetGroup(GameMatcher.Enemy);
            _playerEntitiesGroup = _gameContext.GetGroup(GameMatcher.Player);
        }

        protected override ICollector<StateEntity> GetTrigger(IContext<StateEntity> context)
        {
            return context.CreateCollector(StateMatcher.Defeat);
        }

        protected override bool Filter(StateEntity entity)
        {
            return true;
        }

        protected override void Execute(List<StateEntity> entities)
        {
            _gameContext.currentGameEntity.isGameStarted = false;

            foreach (var enemyEntity in _enemyEntitiesGroup.GetEntities())
            {
                enemyEntity.isSetDefaultState = true;
            }

            foreach (var playerEntity in _playerEntitiesGroup.GetEntities())
            {
                playerEntity.isSetDefaultState = true;
            }

            _gameContext.userDataEntity.ReplaceEnemyDeathCount(0);
        }
    }
}