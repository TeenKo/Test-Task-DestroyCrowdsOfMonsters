using Entitas;
using Entitas.Unity;
using UnityEngine;

namespace Core.Extension
{
    /// <summary>
    /// Base class for all instantiate object through ECS
    /// </summary>
    public abstract class MonoBehAdv : MonoBehaviour, IViewObject
    {
        public virtual void Init(IEntity iEntity)
        {
            gameObject.Link(iEntity);
            iEntity.OnDestroyEntity += OnDestroyEntity;
        }

        public virtual void OnDestroyEntity(IEntity iEntity)
        {
            iEntity.OnDestroyEntity -= OnDestroyEntity;
            gameObject.Unlink();
        }
    }
}