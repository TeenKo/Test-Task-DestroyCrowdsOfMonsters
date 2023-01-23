using Entitas;

public class PlayerSystems : Systems
{
    public PlayerSystems(Contexts contexts)
    {
        Add(new SpawnPlayerReactiveSystem(contexts));
        Add(new MovePlayerExecuteSystem(contexts));
        Add(new PlayerDeathReactiveSystem(contexts));
    }
}