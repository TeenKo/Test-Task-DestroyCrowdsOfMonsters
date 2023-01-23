using Core.Extension;
using Entitas;
using System;
using UnityEngine;

namespace Core.GameLevels
{
    public class LevelSchema : MonoBehAdvGameLevelCleanup
    {
        public string GameObjectName
        {
            get => gameObject.name;
            set => gameObject.name = value;
        }

        public override void Init(IEntity iEntity)
        {
            base.Init(iEntity);
            GameEntity.isLevel = true;
        }
    }
}