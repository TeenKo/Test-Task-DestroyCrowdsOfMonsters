using Entitas;
using UnityEngine;

public class ControlInitializeSystem : IInitializeSystem
{
    private Contexts _contexts;
    public ControlInitializeSystem(Contexts contexts)
    {
        _contexts = contexts;
        _contexts.input.isMouseContol = true;
    }
    public void Initialize()
    {
        var mouseControllEntity = _contexts.input.mouseContolEntity;
        mouseControllEntity.AddCameraRay(default);
        mouseControllEntity.AddCameraRayDistance(1000000f);
        mouseControllEntity.AddMousePosition(Vector3.zero);
    }
}