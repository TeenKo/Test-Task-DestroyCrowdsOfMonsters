//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    static readonly Core.Input.JoystickActiveComponent joystickActiveComponent = new Core.Input.JoystickActiveComponent();

    public bool isJoystickActive {
        get { return HasComponent(GameComponentsLookup.JoystickActive); }
        set {
            if (value != isJoystickActive) {
                var index = GameComponentsLookup.JoystickActive;
                if (value) {
                    var componentPool = GetComponentPool(index);
                    var component = componentPool.Count > 0
                            ? componentPool.Pop()
                            : joystickActiveComponent;

                    AddComponent(index, component);
                } else {
                    RemoveComponent(index);
                }
            }
        }
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

    static Entitas.IMatcher<GameEntity> _matcherJoystickActive;

    public static Entitas.IMatcher<GameEntity> JoystickActive {
        get {
            if (_matcherJoystickActive == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.JoystickActive);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherJoystickActive = matcher;
            }

            return _matcherJoystickActive;
        }
    }
}
