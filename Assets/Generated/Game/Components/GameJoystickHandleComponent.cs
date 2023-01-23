//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public Core.Input.JoystickHandleComponent joystickHandle { get { return (Core.Input.JoystickHandleComponent)GetComponent(GameComponentsLookup.JoystickHandle); } }
    public bool hasJoystickHandle { get { return HasComponent(GameComponentsLookup.JoystickHandle); } }

    public void AddJoystickHandle(UnityEngine.RectTransform newValue) {
        var index = GameComponentsLookup.JoystickHandle;
        var component = (Core.Input.JoystickHandleComponent)CreateComponent(index, typeof(Core.Input.JoystickHandleComponent));
        component.value = newValue;
        AddComponent(index, component);
    }

    public void ReplaceJoystickHandle(UnityEngine.RectTransform newValue) {
        var index = GameComponentsLookup.JoystickHandle;
        var component = (Core.Input.JoystickHandleComponent)CreateComponent(index, typeof(Core.Input.JoystickHandleComponent));
        component.value = newValue;
        ReplaceComponent(index, component);
    }

    public void RemoveJoystickHandle() {
        RemoveComponent(GameComponentsLookup.JoystickHandle);
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

    static Entitas.IMatcher<GameEntity> _matcherJoystickHandle;

    public static Entitas.IMatcher<GameEntity> JoystickHandle {
        get {
            if (_matcherJoystickHandle == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.JoystickHandle);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherJoystickHandle = matcher;
            }

            return _matcherJoystickHandle;
        }
    }
}
