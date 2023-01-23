using Entitas;
using UnityEngine;

[Game]
public sealed class PlayerComponent : IComponent
{

}

[Game]
public sealed class AmmoTransformComponent : IComponent
{
    public Transform value;
}

[Game]
public sealed class DistanceCameraFrusturmsComponent : IComponent
{
    public float[] value;
}
