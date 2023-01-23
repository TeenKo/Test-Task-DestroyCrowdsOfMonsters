using Entitas;

public class CameraSystems : Systems
{
    public CameraSystems(Contexts contexts)
    {
        Add(new GetDistanceCameraFrusturmsReactiveSystem(contexts));
        Add(new CameraRayReactiveSystem(contexts));
        Add(new FolloweCameraFromPlayerExecuteSystem(contexts));
    }
}