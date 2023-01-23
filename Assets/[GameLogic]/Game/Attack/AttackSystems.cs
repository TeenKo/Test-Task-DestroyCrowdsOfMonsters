using Entitas;

public class AttackSystems : Systems
{
    public AttackSystems(Contexts contexts)
    {
        Add(new StartAttackReactiveSystem(contexts));
        Add(new ShootReactiveSystem(contexts));
    }
}
