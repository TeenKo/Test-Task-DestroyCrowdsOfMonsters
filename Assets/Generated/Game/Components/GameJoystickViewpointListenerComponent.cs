//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public JoystickViewpointListenerComponent joystickViewpointListener { get { return (JoystickViewpointListenerComponent)GetComponent(GameComponentsLookup.JoystickViewpointListener); } }
    public bool hasJoystickViewpointListener { get { return HasComponent(GameComponentsLookup.JoystickViewpointListener); } }

    public void AddJoystickViewpointListener(System.Collections.Generic.List<IJoystickViewpointListener> newValue) {
        var index = GameComponentsLookup.JoystickViewpointListener;
        var component = (JoystickViewpointListenerComponent)CreateComponent(index, typeof(JoystickViewpointListenerComponent));
        component.value = newValue;
        AddComponent(index, component);
    }

    public void ReplaceJoystickViewpointListener(System.Collections.Generic.List<IJoystickViewpointListener> newValue) {
        var index = GameComponentsLookup.JoystickViewpointListener;
        var component = (JoystickViewpointListenerComponent)CreateComponent(index, typeof(JoystickViewpointListenerComponent));
        component.value = newValue;
        ReplaceComponent(index, component);
    }

    public void RemoveJoystickViewpointListener() {
        RemoveComponent(GameComponentsLookup.JoystickViewpointListener);
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

    static Entitas.IMatcher<GameEntity> _matcherJoystickViewpointListener;

    public static Entitas.IMatcher<GameEntity> JoystickViewpointListener {
        get {
            if (_matcherJoystickViewpointListener == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.JoystickViewpointListener);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherJoystickViewpointListener = matcher;
            }

            return _matcherJoystickViewpointListener;
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

    public void AddJoystickViewpointListener(IJoystickViewpointListener value) {
        var listeners = hasJoystickViewpointListener
            ? joystickViewpointListener.value
            : new System.Collections.Generic.List<IJoystickViewpointListener>();
        listeners.Add(value);
        ReplaceJoystickViewpointListener(listeners);
    }

    public void RemoveJoystickViewpointListener(IJoystickViewpointListener value, bool removeComponentWhenEmpty = true) {
        var listeners = joystickViewpointListener.value;
        listeners.Remove(value);
        if (removeComponentWhenEmpty && listeners.Count == 0) {
            RemoveJoystickViewpointListener();
        } else {
            ReplaceJoystickViewpointListener(listeners);
        }
    }
}
