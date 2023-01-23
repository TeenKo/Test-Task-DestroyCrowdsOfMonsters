using Entitas;
using Entitas.CodeGeneration.Attributes;
using UnityEngine;

[Game, Cleanup(CleanupMode.DestroyEntity)]
public sealed class StartAttackComponent : IComponent
{

}