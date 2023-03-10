//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.EventSystemGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public sealed class JoystickMoveThresholdEventSystem : Entitas.ReactiveSystem<GameEntity> {

    readonly System.Collections.Generic.List<IJoystickMoveThresholdListener> _listenerBuffer;

    public JoystickMoveThresholdEventSystem(Contexts contexts) : base(contexts.game) {
        _listenerBuffer = new System.Collections.Generic.List<IJoystickMoveThresholdListener>();
    }

    protected override Entitas.ICollector<GameEntity> GetTrigger(Entitas.IContext<GameEntity> context) {
        return Entitas.CollectorContextExtension.CreateCollector(
            context, Entitas.TriggerOnEventMatcherExtension.Added(GameMatcher.JoystickMoveThreshold)
        );
    }

    protected override bool Filter(GameEntity entity) {
        return entity.hasJoystickMoveThreshold && entity.hasJoystickMoveThresholdListener;
    }

    protected override void Execute(System.Collections.Generic.List<GameEntity> entities) {
        foreach (var e in entities) {
            var component = e.joystickMoveThreshold;
            _listenerBuffer.Clear();
            _listenerBuffer.AddRange(e.joystickMoveThresholdListener.value);
            foreach (var listener in _listenerBuffer) {
                listener.OnJoystickMoveThreshold(e, component.value);
            }
        }
    }
}
