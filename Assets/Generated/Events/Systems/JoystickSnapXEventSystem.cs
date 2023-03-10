//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.EventSystemGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public sealed class JoystickSnapXEventSystem : Entitas.ReactiveSystem<GameEntity> {

    readonly System.Collections.Generic.List<IJoystickSnapXListener> _listenerBuffer;

    public JoystickSnapXEventSystem(Contexts contexts) : base(contexts.game) {
        _listenerBuffer = new System.Collections.Generic.List<IJoystickSnapXListener>();
    }

    protected override Entitas.ICollector<GameEntity> GetTrigger(Entitas.IContext<GameEntity> context) {
        return Entitas.CollectorContextExtension.CreateCollector(
            context, Entitas.TriggerOnEventMatcherExtension.Added(GameMatcher.JoystickSnapX)
        );
    }

    protected override bool Filter(GameEntity entity) {
        return entity.hasJoystickSnapX && entity.hasJoystickSnapXListener;
    }

    protected override void Execute(System.Collections.Generic.List<GameEntity> entities) {
        foreach (var e in entities) {
            var component = e.joystickSnapX;
            _listenerBuffer.Clear();
            _listenerBuffer.AddRange(e.joystickSnapXListener.value);
            foreach (var listener in _listenerBuffer) {
                listener.OnJoystickSnapX(e, component.value);
            }
        }
    }
}
