//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.Roslyn.CodeGeneration.Plugins.CleanupSystemGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using System.Collections.Generic;
using Entitas;

public sealed class RemoveSaveDataGameSystem : ICleanupSystem {

    readonly IGroup<GameEntity> _group;
    readonly List<GameEntity> _buffer = new List<GameEntity>();

    public RemoveSaveDataGameSystem(Contexts contexts) {
        _group = contexts.game.GetGroup(GameMatcher.SaveData);
    }

    public void Cleanup() {
        foreach (var e in _group.GetEntities(_buffer)) {
            e.systemTriggerSaveData = false;
        }
    }
}
