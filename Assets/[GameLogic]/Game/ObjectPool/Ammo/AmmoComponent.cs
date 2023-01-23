using Entitas;
using Entitas.CodeGeneration.Attributes;
using UnityEngine;

public enum AmmoPoolState
{
    Idle,
    Ready,
    Busy
}

[Game]
public sealed class AmmoComponent : IComponent
{

}

[Game, Event(EventTarget.Self)]
public sealed class AmmoStateComponent : IComponent
{
    public AmmoPoolState value;
}

[Game, Cleanup(CleanupMode.DestroyEntity)]
public sealed class CreateAmmoComponent : IComponent
{

}

[Game, Cleanup(CleanupMode.RemoveComponent)]
public sealed class ExplosionComponent : IComponent
{

}