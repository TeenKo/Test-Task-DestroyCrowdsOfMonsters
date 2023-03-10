//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.EventSystemGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public sealed class JoystickAxisOptionsEventSystem : Entitas.ReactiveSystem<GameEntity> {

    readonly System.Collections.Generic.List<IJoystickAxisOptionsListener> _listenerBuffer;

    public JoystickAxisOptionsEventSystem(Contexts contexts) : base(contexts.game) {
        _listenerBuffer = new System.Collections.Generic.List<IJoystickAxisOptionsListener>();
    }

    protected override Entitas.ICollector<GameEntity> GetTrigger(Entitas.IContext<GameEntity> context) {
        return Entitas.CollectorContextExtension.CreateCollector(
            context, Entitas.TriggerOnEventMatcherExtension.Added(GameMatcher.JoystickAxisOptions)
        );
    }

    protected override bool Filter(GameEntity entity) {
        return entity.hasJoystickAxisOptions && entity.hasJoystickAxisOptionsListener;
    }

    protected override void Execute(System.Collections.Generic.List<GameEntity> entities) {
        foreach (var e in entities) {
            var component = e.joystickAxisOptions;
            _listenerBuffer.Clear();
            _listenerBuffer.AddRange(e.joystickAxisOptionsListener.value);
            foreach (var listener in _listenerBuffer) {
                listener.OnJoystickAxisOptions(e, component.value);
            }
        }
    }
}
