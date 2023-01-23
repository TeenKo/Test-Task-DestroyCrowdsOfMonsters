//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.EventSystemGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public sealed class RigidbodyEventSystem : Entitas.ReactiveSystem<GameEntity> {

    readonly System.Collections.Generic.List<IRigidbodyListener> _listenerBuffer;

    public RigidbodyEventSystem(Contexts contexts) : base(contexts.game) {
        _listenerBuffer = new System.Collections.Generic.List<IRigidbodyListener>();
    }

    protected override Entitas.ICollector<GameEntity> GetTrigger(Entitas.IContext<GameEntity> context) {
        return Entitas.CollectorContextExtension.CreateCollector(
            context, Entitas.TriggerOnEventMatcherExtension.Added(GameMatcher.Rigidbody)
        );
    }

    protected override bool Filter(GameEntity entity) {
        return entity.hasRigidbody && entity.hasRigidbodyListener;
    }

    protected override void Execute(System.Collections.Generic.List<GameEntity> entities) {
        foreach (var e in entities) {
            var component = e.rigidbody;
            _listenerBuffer.Clear();
            _listenerBuffer.AddRange(e.rigidbodyListener.value);
            foreach (var listener in _listenerBuffer) {
                listener.OnRigidbody(e, component.value);
            }
        }
    }
}