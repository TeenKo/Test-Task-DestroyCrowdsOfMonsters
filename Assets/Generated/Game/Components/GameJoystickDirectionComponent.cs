//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public Core.Input.JoystickDirectionComponent joystickDirection { get { return (Core.Input.JoystickDirectionComponent)GetComponent(GameComponentsLookup.JoystickDirection); } }
    public bool hasJoystickDirection { get { return HasComponent(GameComponentsLookup.JoystickDirection); } }

    public void AddJoystickDirection(UnityEngine.Vector2 newValue) {
        var index = GameComponentsLookup.JoystickDirection;
        var component = (Core.Input.JoystickDirectionComponent)CreateComponent(index, typeof(Core.Input.JoystickDirectionComponent));
        component.value = newValue;
        AddComponent(index, component);
    }

    public void ReplaceJoystickDirection(UnityEngine.Vector2 newValue) {
        var index = GameComponentsLookup.JoystickDirection;
        var component = (Core.Input.JoystickDirectionComponent)CreateComponent(index, typeof(Core.Input.JoystickDirectionComponent));
        component.value = newValue;
        ReplaceComponent(index, component);
    }

    public void RemoveJoystickDirection() {
        RemoveComponent(GameComponentsLookup.JoystickDirection);
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

    static Entitas.IMatcher<GameEntity> _matcherJoystickDirection;

    public static Entitas.IMatcher<GameEntity> JoystickDirection {
        get {
            if (_matcherJoystickDirection == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.JoystickDirection);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherJoystickDirection = matcher;
            }

            return _matcherJoystickDirection;
        }
    }
}
