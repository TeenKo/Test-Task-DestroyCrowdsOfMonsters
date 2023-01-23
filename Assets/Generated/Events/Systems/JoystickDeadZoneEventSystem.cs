//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.EventSystemGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public sealed class JoystickDeadZoneEventSystem : Entitas.ReactiveSystem<GameEntity> {

    readonly System.Collections.Generic.List<IJoystickDeadZoneListener> _listenerBuffer;

    public JoystickDeadZoneEventSystem(Contexts contexts) : base(contexts.game) {
        _listenerBuffer = new System.Collections.Generic.List<IJoystickDeadZoneListener>();
    }

    protected override Entitas.ICollector<GameEntity> GetTrigger(Entitas.IContext<GameEntity> context) {
        return Entitas.CollectorContextExtension.CreateCollector(
            context, Entitas.TriggerOnEventMatcherExtension.Added(GameMatcher.JoystickDeadZone)
        );
    }

    protected override bool Filter(GameEntity entity) {
        return entity.hasJoystickDeadZone && entity.hasJoystickDeadZoneListener;
    }

    protected override void Execute(System.Collections.Generic.List<GameEntity> entities) {
        foreach (var e in entities) {
            var component = e.joystickDeadZone;
            _listenerBuffer.Clear();
            _listenerBuffer.AddRange(e.joystickDeadZoneListener.value);
            foreach (var listener in _listenerBuffer) {
                listener.OnJoystickDeadZone(e, component.value);
            }
        }
    }
}