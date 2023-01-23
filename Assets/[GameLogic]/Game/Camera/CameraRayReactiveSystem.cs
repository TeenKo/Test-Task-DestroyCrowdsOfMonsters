using Entitas;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class CameraRayReactiveSystem : ReactiveSystem<InputEntity>
{
    private Contexts _contexts;
    private IGroup<GameEntity> _playerEntitiesGroup;
    private GameEntity _playerEntity;
    private Transform _playerTransform;
    private Plane _groundPlane = new Plane(Vector3.up, Vector3.zero);
    private float _rayLength;

    public CameraRayReactiveSystem(Contexts contexts) : base(contexts.input)
    {
        _contexts = contexts;
        _playerEntitiesGroup = contexts.game.GetGroup(GameMatcher.Player);
    }

    protected override ICollector<InputEntity> GetTrigger(IContext<InputEntity> context)
    {
        return context.CreateCollector(InputMatcher.CameraRay.Added());
    }

    protected override bool Filter(InputEntity entity)
    {
        return true;
    }

    protected override void Execute(List<InputEntity> entities)
    {
        SetClassVariables();

        var cameraRay =  entities.FirstOrDefault().cameraRay.value;

        if (_groundPlane.Raycast(cameraRay, out _rayLength))
        {
            Vector3 pointToLook = cameraRay.GetPoint(_rayLength);
            Debug.DrawLine(cameraRay.origin, pointToLook, Color.cyan);

            _playerTransform.LookAt(new Vector3(pointToLook.x, _playerTransform.position.y, pointToLook.z));
            _contexts.input.mouseContolEntity.ReplaceCameraRayDistance(_rayLength);
        }
    }

    private void SetClassVariables()
    {
        if (_playerEntity == null) _playerEntity = _playerEntitiesGroup.GetEntities().FirstOrDefault();

        if (_playerTransform == null) _playerTransform = _playerEntity.transform.value;
    }
}