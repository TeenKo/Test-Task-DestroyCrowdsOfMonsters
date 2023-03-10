//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.EventSystemGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public sealed class JoystickVerticalAxisEventSystem : Entitas.ReactiveSystem<GameEntity> {

    readonly System.Collections.Generic.List<IJoystickVerticalAxisListener> _listenerBuffer;

    public JoystickVerticalAxisEventSystem(Contexts contexts) : base(contexts.game) {
        _listenerBuffer = new System.Collections.Generic.List<IJoystickVerticalAxisListener>();
    }

    protected override Entitas.ICollector<GameEntity> GetTrigger(Entitas.IContext<GameEntity> context) {
        return Entitas.CollectorContextExtension.CreateCollector(
            context, Entitas.TriggerOnEventMatcherExtension.Added(GameMatcher.JoystickVerticalAxis)
        );
    }

    protected override bool Filter(GameEntity entity) {
        return entity.hasJoystickVerticalAxis && entity.hasJoystickVerticalAxisListener;
    }

    protected override void Execute(System.Collections.Generic.List<GameEntity> entities) {
        foreach (var e in entities) {
            var component = e.joystickVerticalAxis;
            _listenerBuffer.Clear();
            _listenerBuffer.AddRange(e.joystickVerticalAxisListener.value);
            foreach (var listener in _listenerBuffer) {
                listener.OnJoystickVerticalAxis(e, component.value);
            }
        }
    }
}
