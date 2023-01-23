//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public Core.Input.JoystickDeadZoneComponent joystickDeadZone { get { return (Core.Input.JoystickDeadZoneComponent)GetComponent(GameComponentsLookup.JoystickDeadZone); } }
    public bool hasJoystickDeadZone { get { return HasComponent(GameComponentsLookup.JoystickDeadZone); } }

    public void AddJoystickDeadZone(float newValue) {
        var index = GameComponentsLookup.JoystickDeadZone;
        var component = (Core.Input.JoystickDeadZoneComponent)CreateComponent(index, typeof(Core.Input.JoystickDeadZoneComponent));
        component.value = newValue;
        AddComponent(index, component);
    }

    public void ReplaceJoystickDeadZone(float newValue) {
        var index = GameComponentsLookup.JoystickDeadZone;
        var component = (Core.Input.JoystickDeadZoneComponent)CreateComponent(index, typeof(Core.Input.JoystickDeadZoneComponent));
        component.value = newValue;
        ReplaceComponent(index, component);
    }

    public void RemoveJoystickDeadZone() {
        RemoveComponent(GameComponentsLookup.JoystickDeadZone);
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

    static Entitas.IMatcher<GameEntity> _matcherJoystickDeadZone;

    public static Entitas.IMatcher<GameEntity> JoystickDeadZone {
        get {
            if (_matcherJoystickDeadZone == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.JoystickDeadZone);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherJoystickDeadZone = matcher;
            }

            return _matcherJoystickDeadZone;
        }
    }
}
