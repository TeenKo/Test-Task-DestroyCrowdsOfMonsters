using Core.Extension;
using Entitas;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSpawnView : MonoBehAdvGame
{
    public override void Init(IEntity iEntity)
    {
        base.Init(iEntity);
        GameEntity.isPlayerSpawnPoint = true;
    }
}