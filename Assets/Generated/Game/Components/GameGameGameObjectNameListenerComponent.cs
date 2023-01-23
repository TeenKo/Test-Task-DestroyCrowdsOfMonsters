//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public GameGameObjectNameListenerComponent gameGameObjectNameListener { get { return (GameGameObjectNameListenerComponent)GetComponent(GameComponentsLookup.GameGameObjectNameListener); } }
    public bool hasGameGameObjectNameListener { get { return HasComponent(GameComponentsLookup.GameGameObjectNameListener); } }

    public void AddGameGameObjectNameListener(System.Collections.Generic.List<IGameGameObjectNameListener> newValue) {
        var index = GameComponentsLookup.GameGameObjectNameListener;
        var component = (GameGameObjectNameListenerComponent)CreateComponent(index, typeof(GameGameObjectNameListenerComponent));
        component.value = newValue;
        AddComponent(index, component);
    }

    public void ReplaceGameGameObjectNameListener(System.Collections.Generic.List<IGameGameObjectNameListener> newValue) {
        var index = GameComponentsLookup.GameGameObjectNameListener;
        var component = (GameGameObjectNameListenerComponent)CreateComponent(index, typeof(GameGameObjectNameListenerComponent));
        component.value = newValue;
        ReplaceComponent(index, component);
    }

    public void RemoveGameGameObjectNameListener() {
        RemoveComponent(GameComponentsLookup.GameGameObjectNameListener);
    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentMatcherApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public sealed partial class GameMatcher {

    static Entitas.IMatcher<GameEntity> _matcherGameGameObjectNameListener;

    public static Entitas.IMatcher<GameEntity> GameGameObjectNameListener {
        get {
            if (_matcherGameGameObjectNameListener == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.GameGameObjectNameListener);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherGameGameObjectNameListener = matcher;
            }

            return _matcherGameGameObjectNameListener;
        }
    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.EventEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public void AddGameGameObjectNameListener(IGameGameObjectNameListener value) {
        var listeners = hasGameGameObjectNameListener
            ? gameGameObjectNameListener.value
            : new System.Collections.Generic.List<IGameGameObjectNameListener>();
        listeners.Add(value);
        ReplaceGameGameObjectNameListener(listeners);
    }

    public void RemoveGameGameObjectNameListener(IGameGameObjectNameListener value, bool removeComponentWhenEmpty = true) {
        var listeners = gameGameObjectNameListener.value;
        listeners.Remove(value);
        if (removeComponentWhenEmpty && listeners.Count == 0) {
            RemoveGameGameObjectNameListener();
        } else {
            ReplaceGameGameObjectNameListener(listeners);
        }
    }
}
