//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.EventSystemGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public sealed class EnemyPoolStateEventSystem : Entitas.ReactiveSystem<GameEntity> {

    readonly System.Collections.Generic.List<IEnemyPoolStateListener> _listenerBuffer;

    public EnemyPoolStateEventSystem(Contexts contexts) : base(contexts.game) {
        _listenerBuffer = new System.Collections.Generic.List<IEnemyPoolStateListener>();
    }

    protected override Entitas.ICollector<GameEntity> GetTrigger(Entitas.IContext<GameEntity> context) {
        return Entitas.CollectorContextExtension.CreateCollector(
            context, Entitas.TriggerOnEventMatcherExtension.Added(GameMatcher.EnemyPoolState)
        );
    }

    protected override bool Filter(GameEntity entity) {
        return entity.hasEnemyPoolState && entity.hasEnemyPoolStateListener;
    }

    protected override void Execute(System.Collections.Generic.List<GameEntity> entities) {
        foreach (var e in entities) {
            var component = e.enemyPoolState;
            _listenerBuffer.Clear();
            _listenerBuffer.AddRange(e.enemyPoolStateListener.value);
            foreach (var listener in _listenerBuffer) {
                listener.OnEnemyPoolState(e, component.value);
            }
        }
    }
}
