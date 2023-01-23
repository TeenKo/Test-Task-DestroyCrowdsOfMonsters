//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public JoystickInputListenerComponent joystickInputListener { get { return (JoystickInputListenerComponent)GetComponent(GameComponentsLookup.JoystickInputListener); } }
    public bool hasJoystickInputListener { get { return HasComponent(GameComponentsLookup.JoystickInputListener); } }

    public void AddJoystickInputListener(System.Collections.Generic.List<IJoystickInputListener> newValue) {
        var index = GameComponentsLookup.JoystickInputListener;
        var component = (JoystickInputListenerComponent)CreateComponent(index, typeof(JoystickInputListenerComponent));
        component.value = newValue;
        AddComponent(index, component);
    }

    public void ReplaceJoystickInputListener(System.Collections.Generic.List<IJoystickInputListener> newValue) {
        var index = GameComponentsLookup.JoystickInputListener;
        var component = (JoystickInputListenerComponent)CreateComponent(index, typeof(JoystickInputListenerComponent));
        component.value = newValue;
        ReplaceComponent(index, component);
    }

    public void RemoveJoystickInputListener() {
        RemoveComponent(GameComponentsLookup.JoystickInputListener);
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

    static Entitas.IMatcher<GameEntity> _matcherJoystickInputListener;

    public static Entitas.IMatcher<GameEntity> JoystickInputListener {
        get {
            if (_matcherJoystickInputListener == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.JoystickInputListener);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherJoystickInputListener = matcher;
            }

            return _matcherJoystickInputListener;
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

    public void AddJoystickInputListener(IJoystickInputListener value) {
        var listeners = hasJoystickInputListener
            ? joystickInputListener.value
            : new System.Collections.Generic.List<IJoystickInputListener>();
        listeners.Add(value);
        ReplaceJoystickInputListener(listeners);
    }

    public void RemoveJoystickInputListener(IJoystickInputListener value, bool removeComponentWhenEmpty = true) {
        var listeners = joystickInputListener.value;
        listeners.Remove(value);
        if (removeComponentWhenEmpty && listeners.Count == 0) {
            RemoveJoystickInputListener();
        } else {
            ReplaceJoystickInputListener(listeners);
        }
    }
}