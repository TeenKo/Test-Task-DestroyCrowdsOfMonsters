using Entitas;
using Entitas.CodeGeneration.Attributes;
using System.Management.Instrumentation;
using UnityEngine;

[Input, Unique]
public sealed class MouseContolComponent : IComponent
{

}

[Input, Event(EventTarget.Self)]
public sealed class CameraRayComponent : IComponent
{
    public Ray value;
}

[Input]
public sealed class CameraRayDistanceComponent : IComponent
{
    public float value;
}

[Input]
public sealed class MousePositionComponent : IComponent
{
    public Vector3 value;
}