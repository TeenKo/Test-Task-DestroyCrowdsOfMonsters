using Entitas;
using System.Linq;
using UnityEngine;

public class MovePlayerExecuteSystem : IExecuteSystem
{
    private Contexts _contexts;
    private IGroup<GameEntity> _playerEntitiesGroup;
    private GameEntity _playerEntity;
    private Transform _playerTransform;

    public MovePlayerExecuteSystem(Contexts contexts)
    {
        _contexts = contexts;
        _playerEntitiesGroup = contexts.game.GetGroup(GameMatcher.Player);
    }
    public void Execute()
    {
        SetClassVariables();

        var xDitection = Input.GetAxis("Horizontal");
        var zDitection = Input.GetAxis("Vertical");

        var moveDirection = new Vector3(xDitection, 0, zDitection);

        _playerTransform.position += moveDirection * _playerEntity.speed.value * Time.deltaTime;
    }

    private void SetClassVariables()
    {
        if (_playerEntity == null) _playerEntity = _playerEntitiesGroup.GetEntities().FirstOrDefault();

        if (_playerTransform == null) _playerTransform = _playerEntity.transform.value;
    }
}