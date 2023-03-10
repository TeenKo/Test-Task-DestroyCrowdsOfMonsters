//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public Core.Input.JoystickMoveThresholdComponent joystickMoveThreshold { get { return (Core.Input.JoystickMoveThresholdComponent)GetComponent(GameComponentsLookup.JoystickMoveThreshold); } }
    public bool hasJoystickMoveThreshold { get { return HasComponent(GameComponentsLookup.JoystickMoveThreshold); } }

    public void AddJoystickMoveThreshold(float newValue) {
        var index = GameComponentsLookup.JoystickMoveThreshold;
        var component = (Core.Input.JoystickMoveThresholdComponent)CreateComponent(index, typeof(Core.Input.JoystickMoveThresholdComponent));
        component.value = newValue;
        AddComponent(index, component);
    }

    public void ReplaceJoystickMoveThreshold(float newValue) {
        var index = GameComponentsLookup.JoystickMoveThreshold;
        var component = (Core.Input.JoystickMoveThresholdComponent)CreateComponent(index, typeof(Core.Input.JoystickMoveThresholdComponent));
        component.value = newValue;
        ReplaceComponent(index, component);
    }

    public void RemoveJoystickMoveThreshold() {
        RemoveComponent(GameComponentsLookup.JoystickMoveThreshold);
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

    static Entitas.IMatcher<GameEntity> _matcherJoystickMoveThreshold;

    public static Entitas.IMatcher<GameEntity> JoystickMoveThreshold {
        get {
            if (_matcherJoystickMoveThreshold == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.JoystickMoveThreshold);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherJoystickMoveThreshold = matcher;
            }

            return _matcherJoystickMoveThreshold;
        }
    }
}
