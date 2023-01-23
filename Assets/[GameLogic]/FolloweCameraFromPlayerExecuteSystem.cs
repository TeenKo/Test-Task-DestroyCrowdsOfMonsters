using Core.Configs;
using Entitas;
using System.Linq;
using UnityEngine;

public class FolloweCameraFromPlayerExecuteSystem : IExecuteSystem
{
    private Contexts _contexts;
    private IGroup<GameEntity> _playerEntitiesGroup;
    private IGroup<GameEntity> _cameraEntitiesGroup;
    private GameConfig _gameConfig;
    private Transform _playerTransform;
    private Transform _cameraTransform;

    public FolloweCameraFromPlayerExecuteSystem(Contexts contexts)
    {
        _contexts = contexts;
        _playerEntitiesGroup = contexts.game.GetGroup(GameMatcher.Player);
        _cameraEntitiesGroup = contexts.game.GetGroup(GameMatcher.MainCamera);
        _gameConfig = ConfigsCatalogsManager.GetConfig<GameConfig>();
    }
    public void Execute()
    {
        SetClassVariables();

        var desirePosition = _playerTransform.position + _gameConfig.CameraOffset;
        var smoothedPosition = Vector3.Lerp(_cameraTransform.position, desirePosition, _gameConfig.SmoothSpeed*Time.deltaTime);
        _cameraTransform.position = smoothedPosition;
    }

    public void SetClassVariables()
    {
        if (_playerTransform == null) _playerTransform = _playerEntitiesGroup.GetEntities().FirstOrDefault().transform.value;
        if (_cameraTransform == null) _cameraTransform = _cameraEntitiesGroup.GetEntities().FirstOrDefault().transform.value;
    }
}