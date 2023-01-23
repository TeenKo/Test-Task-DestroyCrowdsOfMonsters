using Entitas;

public class ControlSystems : Systems
{
    public ControlSystems(Contexts contexts)
    {
        Add(new ControlInitializeSystem(contexts));
        Add(new MouseTurnExecuteSystem(contexts));
    }
}
