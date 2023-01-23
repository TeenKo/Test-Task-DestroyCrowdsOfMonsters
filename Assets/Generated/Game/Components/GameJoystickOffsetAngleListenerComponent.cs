//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public JoystickOffsetAngleListenerComponent joystickOffsetAngleListener { get { return (JoystickOffsetAngleListenerComponent)GetComponent(GameComponentsLookup.JoystickOffsetAngleListener); } }
    public bool hasJoystickOffsetAngleListener { get { return HasComponent(GameComponentsLookup.JoystickOffsetAngleListener); } }

    public void AddJoystickOffsetAngleListener(System.Collections.Generic.List<IJoystickOffsetAngleListener> newValue) {
        var index = GameComponentsLookup.JoystickOffsetAngleListener;
        var component = (JoystickOffsetAngleListenerComponent)CreateComponent(index, typeof(JoystickOffsetAngleListenerComponent));
        component.value = newValue;
        AddComponent(index, component);
    }

    public void ReplaceJoystickOffsetAngleListener(System.Collections.Generic.List<IJoystickOffsetAngleListener> newValue) {
        var index = GameComponentsLookup.JoystickOffsetAngleListener;
        var component = (JoystickOffsetAngleListenerComponent)CreateComponent(index, typeof(JoystickOffsetAngleListenerComponent));
        component.value = newValue;
        ReplaceComponent(index, component);
    }

    public void RemoveJoystickOffsetAngleListener() {
        RemoveComponent(GameComponentsLookup.JoystickOffsetAngleListener);
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

    static Entitas.IMatcher<GameEntity> _matcherJoystickOffsetAngleListener;

    public static Entitas.IMatcher<GameEntity> JoystickOffsetAngleListener {
        get {
            if (_matcherJoystickOffsetAngleListener == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.JoystickOffsetAngleListener);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherJoystickOffsetAngleListener = matcher;
            }

            return _matcherJoystickOffsetAngleListener;
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

    public void AddJoystickOffsetAngleListener(IJoystickOffsetAngleListener value) {
        var listeners = hasJoystickOffsetAngleListener
            ? joystickOffsetAngleListener.value
            : new System.Collections.Generic.List<IJoystickOffsetAngleListener>();
        listeners.Add(value);
        ReplaceJoystickOffsetAngleListener(listeners);
    }

    public void RemoveJoystickOffsetAngleListener(IJoystickOffsetAngleListener value, bool removeComponentWhenEmpty = true) {
        var listeners = joystickOffsetAngleListener.value;
        listeners.Remove(value);
        if (removeComponentWhenEmpty && listeners.Count == 0) {
            RemoveJoystickOffsetAngleListener();
        } else {
            ReplaceJoystickOffsetAngleListener(listeners);
        }
    }
}