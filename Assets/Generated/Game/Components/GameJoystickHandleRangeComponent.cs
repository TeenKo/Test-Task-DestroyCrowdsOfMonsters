//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public Core.Input.JoystickHandleRangeComponent joystickHandleRange { get { return (Core.Input.JoystickHandleRangeComponent)GetComponent(GameComponentsLookup.JoystickHandleRange); } }
    public bool hasJoystickHandleRange { get { return HasComponent(GameComponentsLookup.JoystickHandleRange); } }

    public void AddJoystickHandleRange(float newValue) {
        var index = GameComponentsLookup.JoystickHandleRange;
        var component = (Core.Input.JoystickHandleRangeComponent)CreateComponent(index, typeof(Core.Input.JoystickHandleRangeComponent));
        component.value = newValue;
        AddComponent(index, component);
    }

    public void ReplaceJoystickHandleRange(float newValue) {
        var index = GameComponentsLookup.JoystickHandleRange;
        var component = (Core.Input.JoystickHandleRangeComponent)CreateComponent(index, typeof(Core.Input.JoystickHandleRangeComponent));
        component.value = newValue;
        ReplaceComponent(index, component);
    }

    public void RemoveJoystickHandleRange() {
        RemoveComponent(GameComponentsLookup.JoystickHandleRange);
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

    static Entitas.IMatcher<GameEntity> _matcherJoystickHandleRange;

    public static Entitas.IMatcher<GameEntity> JoystickHandleRange {
        get {
            if (_matcherJoystickHandleRange == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.JoystickHandleRange);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherJoystickHandleRange = matcher;
            }

            return _matcherJoystickHandleRange;
        }
    }
}
