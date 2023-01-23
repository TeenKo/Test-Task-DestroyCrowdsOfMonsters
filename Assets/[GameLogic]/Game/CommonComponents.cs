using Entitas;
using Entitas.CodeGeneration.Attributes;
using UnityEngine;

[Game]
public sealed class SpeedComponent : IComponent
{
    public float value;
}

[Game]
public sealed class IndexComponent : IComponent
{
    public int value;
}

[Game, Event(EventTarget.Self)]
public sealed class EndPositionComponent : IComponent
{
    public Vector3 value;
}

[Game, Event(EventTarget.Self)]
public sealed class HealthComponent : IComponent
{
    public float value;
}

[Game]
public sealed class DefeanceComponent : IComponent
{
    public float value;
}

[Game]
public sealed class AttackSpeedComponent : IComponent
{
    public float value;
}

[Game]
public sealed class DamageComponent : IComponent
{
    public float value;
}

[Game]
public sealed class AttackDistanceComponent : IComponent
{
    public float value;
}

[Game, Cleanup(CleanupMode.RemoveComponent), Event(EventTarget.Self)]
public sealed class DeathComponent : IComponent
{

}

[Game, Cleanup(CleanupMode.RemoveComponent), Event(EventTarget.Self)]
public sealed class TakeDamageComponent : IComponent
{
    
}

[Game]
public sealed class EnemyCountComponent : IComponent
{
    public int value;
}

[Game, Event(EventTarget.Self)]
public sealed class EnemyDeathCountComponent : IComponent
{
    public int value;
}

[Game]
public sealed class AttackRechargeComponent : IComponent
{
    public float value;
}

[Game, Event(EventTarget.Self), Cleanup(CleanupMode.RemoveComponent)]
public sealed class SetDefaultStateComponent : IComponent
{

}