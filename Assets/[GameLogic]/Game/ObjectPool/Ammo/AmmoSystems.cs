using Entitas;

public class AmmoSystems : Systems
{
    public AmmoSystems(Contexts contexts)
    {
        Add(new ExplosionReactiveSystem(contexts));
    }
}
