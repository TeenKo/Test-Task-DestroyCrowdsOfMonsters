using Entitas;

public sealed class GameSystems : Systems
{
    public GameSystems(Contexts contexts, PoolConfig gameConfig)
    {
        // add you game logic here
        Add(new GameLoadPlayerDataCompleteReactSystem(contexts.game, contexts.level));

        //Game Systems
        Add(new GameInitializeSystem(contexts));
        Add(new SpawnPlayerReactiveSystem(contexts));
        Add(new GetDistanceCameraFrusturmsReactiveSystem(contexts));
        Add(new CameraRayReactiveSystem(contexts));
        Add(new MovePlayerExecuteSystem(contexts));
        Add(new FolloweCameraFromPlayerExecuteSystem(contexts));
        Add(new PlayerDeathReactiveSystem(contexts));

        Add(new AmmoSystems(contexts));
        Add(new AttackSystems(contexts));
        Add(new EnemySystems(contexts));
        
        Add(new CreateAmmoReactiveSystem(contexts));

        // ui logic here
        Add(new UI.UISystems(contexts.game, contexts.state, contexts.ui));
    }
}