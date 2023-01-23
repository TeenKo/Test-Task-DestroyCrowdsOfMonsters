using Entitas;
using Entitas.CodeGeneration.Attributes;

public enum EnemyPoolState
{
    Idle,
    Live,
    Death
}

[Game]
public sealed class EnemyComponent : IComponent
{

}

[Game]
public sealed class EnemyTypeComponent : IComponent
{
    public PoolConfig.EnemyType value;
}

[Game, Cleanup(CleanupMode.DestroyEntity), FlagPrefix("request")]
public sealed class MoveEnemyOutCameraComponent : IComponent
{

}

[Game, Event(EventTarget.Self)]
public sealed class EnemyPoolStateComponent : IComponent
{
    public EnemyPoolState value;
}

[Game]
public sealed class EnemyAttackComponent : IComponent
{

}

[Game, Cleanup(CleanupMode.RemoveComponent)]
public sealed class AttackPlayerComponent : IComponent
{

}