//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public Core.Input.JoystickBaseRectComponent joystickBaseRect { get { return (Core.Input.JoystickBaseRectComponent)GetComponent(GameComponentsLookup.JoystickBaseRect); } }
    public bool hasJoystickBaseRect { get { return HasComponent(GameComponentsLookup.JoystickBaseRect); } }

    public void AddJoystickBaseRect(UnityEngine.RectTransform newValue) {
        var index = GameComponentsLookup.JoystickBaseRect;
        var component = (Core.Input.JoystickBaseRectComponent)CreateComponent(index, typeof(Core.Input.JoystickBaseRectComponent));
        component.value = newValue;
        AddComponent(index, component);
    }

    public void ReplaceJoystickBaseRect(UnityEngine.RectTransform newValue) {
        var index = GameComponentsLookup.JoystickBaseRect;
        var component = (Core.Input.JoystickBaseRectComponent)CreateComponent(index, typeof(Core.Input.JoystickBaseRectComponent));
        component.value = newValue;
        ReplaceComponent(index, component);
    }

    public void RemoveJoystickBaseRect() {
        RemoveComponent(GameComponentsLookup.JoystickBaseRect);
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

    static Entitas.IMatcher<GameEntity> _matcherJoystickBaseRect;

    public static Entitas.IMatcher<GameEntity> JoystickBaseRect {
        get {
            if (_matcherJoystickBaseRect == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.JoystickBaseRect);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherJoystickBaseRect = matcher;
            }

            return _matcherJoystickBaseRect;
        }
    }
}
