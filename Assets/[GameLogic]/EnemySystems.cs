using Entitas;

public class EnemySystems : Systems
{
    public EnemySystems(Contexts contexts)
    {
        Add(new MoveEnemyOutCameraReactiveSystem(contexts));
        Add(new EnemyLiveExecuteSystem(contexts));
        Add(new EnemyTakeDamage(contexts));
        Add(new DeathEnemyReactiveSystem(contexts));
        Add(new EnemyIdleStateReactiveSystem(contexts));
        Add(new EnemyCountReactiveSystem(contexts));
        Add(new SpawnNewEnemyReactiveSystem(contexts));

        Add(new EnemyAttackReactiveSystem(contexts));
        Add(new AttackPlayerReactiveSystem(contexts));
        Add(new TimerAttackRechargeReactiveSystem(contexts));
    }
}