//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.EventSystemGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public sealed class UiGameObjectNameEventSystem : Entitas.ReactiveSystem<UiEntity> {

    readonly System.Collections.Generic.List<IUiGameObjectNameListener> _listenerBuffer;

    public UiGameObjectNameEventSystem(Contexts contexts) : base(contexts.ui) {
        _listenerBuffer = new System.Collections.Generic.List<IUiGameObjectNameListener>();
    }

    protected override Entitas.ICollector<UiEntity> GetTrigger(Entitas.IContext<UiEntity> context) {
        return Entitas.CollectorContextExtension.CreateCollector(
            context, Entitas.TriggerOnEventMatcherExtension.Added(UiMatcher.GameObjectName)
        );
    }

    protected override bool Filter(UiEntity entity) {
        return entity.hasGameObjectName && entity.hasUiGameObjectNameListener;
    }

    protected override void Execute(System.Collections.Generic.List<UiEntity> entities) {
        foreach (var e in entities) {
            var component = e.gameObjectName;
            _listenerBuffer.Clear();
            _listenerBuffer.AddRange(e.uiGameObjectNameListener.value);
            foreach (var listener in _listenerBuffer) {
                listener.OnGameObjectName(e, component.value);
            }
        }
    }
}
