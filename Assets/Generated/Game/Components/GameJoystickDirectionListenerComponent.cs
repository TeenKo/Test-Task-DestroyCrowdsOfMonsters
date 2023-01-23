//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public JoystickDirectionListenerComponent joystickDirectionListener { get { return (JoystickDirectionListenerComponent)GetComponent(GameComponentsLookup.JoystickDirectionListener); } }
    public bool hasJoystickDirectionListener { get { return HasComponent(GameComponentsLookup.JoystickDirectionListener); } }

    public void AddJoystickDirectionListener(System.Collections.Generic.List<IJoystickDirectionListener> newValue) {
        var index = GameComponentsLookup.JoystickDirectionListener;
        var component = (JoystickDirectionListenerComponent)CreateComponent(index, typeof(JoystickDirectionListenerComponent));
        component.value = newValue;
        AddComponent(index, component);
    }

    public void ReplaceJoystickDirectionListener(System.Collections.Generic.List<IJoystickDirectionListener> newValue) {
        var index = GameComponentsLookup.JoystickDirectionListener;
        var component = (JoystickDirectionListenerComponent)CreateComponent(index, typeof(JoystickDirectionListenerComponent));
        component.value = newValue;
        ReplaceComponent(index, component);
    }

    public void RemoveJoystickDirectionListener() {
        RemoveComponent(GameComponentsLookup.JoystickDirectionListener);
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

    static Entitas.IMatcher<GameEntity> _matcherJoystickDirectionListener;

    public static Entitas.IMatcher<GameEntity> JoystickDirectionListener {
        get {
            if (_matcherJoystickDirectionListener == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.JoystickDirectionListener);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherJoystickDirectionListener = matcher;
            }

            return _matcherJoystickDirectionListener;
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

    public void AddJoystickDirectionListener(IJoystickDirectionListener value) {
        var listeners = hasJoystickDirectionListener
            ? joystickDirectionListener.value
            : new System.Collections.Generic.List<IJoystickDirectionListener>();
        listeners.Add(value);
        ReplaceJoystickDirectionListener(listeners);
    }

    public void RemoveJoystickDirectionListener(IJoystickDirectionListener value, bool removeComponentWhenEmpty = true) {
        var listeners = joystickDirectionListener.value;
        listeners.Remove(value);
        if (removeComponentWhenEmpty && listeners.Count == 0) {
            RemoveJoystickDirectionListener();
        } else {
            ReplaceJoystickDirectionListener(listeners);
        }
    }
}