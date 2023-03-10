//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public JoystickDeadZoneListenerComponent joystickDeadZoneListener { get { return (JoystickDeadZoneListenerComponent)GetComponent(GameComponentsLookup.JoystickDeadZoneListener); } }
    public bool hasJoystickDeadZoneListener { get { return HasComponent(GameComponentsLookup.JoystickDeadZoneListener); } }

    public void AddJoystickDeadZoneListener(System.Collections.Generic.List<IJoystickDeadZoneListener> newValue) {
        var index = GameComponentsLookup.JoystickDeadZoneListener;
        var component = (JoystickDeadZoneListenerComponent)CreateComponent(index, typeof(JoystickDeadZoneListenerComponent));
        component.value = newValue;
        AddComponent(index, component);
    }

    public void ReplaceJoystickDeadZoneListener(System.Collections.Generic.List<IJoystickDeadZoneListener> newValue) {
        var index = GameComponentsLookup.JoystickDeadZoneListener;
        var component = (JoystickDeadZoneListenerComponent)CreateComponent(index, typeof(JoystickDeadZoneListenerComponent));
        component.value = newValue;
        ReplaceComponent(index, component);
    }

    public void RemoveJoystickDeadZoneListener() {
        RemoveComponent(GameComponentsLookup.JoystickDeadZoneListener);
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

    static Entitas.IMatcher<GameEntity> _matcherJoystickDeadZoneListener;

    public static Entitas.IMatcher<GameEntity> JoystickDeadZoneListener {
        get {
            if (_matcherJoystickDeadZoneListener == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.JoystickDeadZoneListener);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherJoystickDeadZoneListener = matcher;
            }

            return _matcherJoystickDeadZoneListener;
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

    public void AddJoystickDeadZoneListener(IJoystickDeadZoneListener value) {
        var listeners = hasJoystickDeadZoneListener
            ? joystickDeadZoneListener.value
            : new System.Collections.Generic.List<IJoystickDeadZoneListener>();
        listeners.Add(value);
        ReplaceJoystickDeadZoneListener(listeners);
    }

    public void RemoveJoystickDeadZoneListener(IJoystickDeadZoneListener value, bool removeComponentWhenEmpty = true) {
        var listeners = joystickDeadZoneListener.value;
        listeners.Remove(value);
        if (removeComponentWhenEmpty && listeners.Count == 0) {
            RemoveJoystickDeadZoneListener();
        } else {
            ReplaceJoystickDeadZoneListener(listeners);
        }
    }
}
