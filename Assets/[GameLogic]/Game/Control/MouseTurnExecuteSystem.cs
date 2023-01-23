using Core.Configs;
using Entitas;
using System.Linq;
using UnityEngine;

public class MouseTurnExecuteSystem : IExecuteSystem
{
    private Contexts _contexts;
    private IGroup<GameEntity> _mainCameraEntitiesGroup;
    private PoolConfig _gameConfig;
    private GameEntity _mainCameraEntity;

    public MouseTurnExecuteSystem(Contexts contexts)
    {
        _contexts = contexts;
        _mainCameraEntitiesGroup = contexts.game.GetGroup(GameMatcher.MainCamera);
        _gameConfig = ConfigsCatalogsManager.GetConfig<PoolConfig>();
    }

    public void Execute()
    {
        if (Contexts.sharedInstance.game.currentGameEntity.isGameStarted == false) return;
        if (_mainCameraEntity == null) _mainCameraEntity = _mainCameraEntitiesGroup.GetEntities().FirstOrDefault();

        var cameraRay = _mainCameraEntity.mainCamera.value.ScreenPointToRay(Input.mousePosition);

        _contexts.input.mouseContolEntity.ReplaceCameraRay(cameraRay);
    }
}