//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public Core.Input.JoystickBackgroundAnchoredPositionComponent joystickBackgroundAnchoredPosition { get { return (Core.Input.JoystickBackgroundAnchoredPositionComponent)GetComponent(GameComponentsLookup.JoystickBackgroundAnchoredPosition); } }
    public bool hasJoystickBackgroundAnchoredPosition { get { return HasComponent(GameComponentsLookup.JoystickBackgroundAnchoredPosition); } }

    public void AddJoystickBackgroundAnchoredPosition(UnityEngine.Vector2 newValue) {
        var index = GameComponentsLookup.JoystickBackgroundAnchoredPosition;
        var component = (Core.Input.JoystickBackgroundAnchoredPositionComponent)CreateComponent(index, typeof(Core.Input.JoystickBackgroundAnchoredPositionComponent));
        component.value = newValue;
        AddComponent(index, component);
    }

    public void ReplaceJoystickBackgroundAnchoredPosition(UnityEngine.Vector2 newValue) {
        var index = GameComponentsLookup.JoystickBackgroundAnchoredPosition;
        var component = (Core.Input.JoystickBackgroundAnchoredPositionComponent)CreateComponent(index, typeof(Core.Input.JoystickBackgroundAnchoredPositionComponent));
        component.value = newValue;
        ReplaceComponent(index, component);
    }

    public void RemoveJoystickBackgroundAnchoredPosition() {
        RemoveComponent(GameComponentsLookup.JoystickBackgroundAnchoredPosition);
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

    static Entitas.IMatcher<GameEntity> _matcherJoystickBackgroundAnchoredPosition;

    public static Entitas.IMatcher<GameEntity> JoystickBackgroundAnchoredPosition {
        get {
            if (_matcherJoystickBackgroundAnchoredPosition == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.JoystickBackgroundAnchoredPosition);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherJoystickBackgroundAnchoredPosition = matcher;
            }

            return _matcherJoystickBackgroundAnchoredPosition;
        }
    }
}
