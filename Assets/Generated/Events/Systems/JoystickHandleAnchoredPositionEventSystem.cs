//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.EventSystemGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public sealed class JoystickHandleAnchoredPositionEventSystem : Entitas.ReactiveSystem<GameEntity> {

    readonly System.Collections.Generic.List<IJoystickHandleAnchoredPositionListener> _listenerBuffer;

    public JoystickHandleAnchoredPositionEventSystem(Contexts contexts) : base(contexts.game) {
        _listenerBuffer = new System.Collections.Generic.List<IJoystickHandleAnchoredPositionListener>();
    }

    protected override Entitas.ICollector<GameEntity> GetTrigger(Entitas.IContext<GameEntity> context) {
        return Entitas.CollectorContextExtension.CreateCollector(
            context, Entitas.TriggerOnEventMatcherExtension.Added(GameMatcher.JoystickHandleAnchoredPosition)
        );
    }

    protected override bool Filter(GameEntity entity) {
        return entity.hasJoystickHandleAnchoredPosition && entity.hasJoystickHandleAnchoredPositionListener;
    }

    protected override void Execute(System.Collections.Generic.List<GameEntity> entities) {
        foreach (var e in entities) {
            var component = e.joystickHandleAnchoredPosition;
            _listenerBuffer.Clear();
            _listenerBuffer.AddRange(e.joystickHandleAnchoredPositionListener.value);
            foreach (var listener in _listenerBuffer) {
                listener.OnJoystickHandleAnchoredPosition(e, component.value);
            }
        }
    }
}