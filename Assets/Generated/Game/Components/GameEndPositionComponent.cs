//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public EndPositionComponent endPosition { get { return (EndPositionComponent)GetComponent(GameComponentsLookup.EndPosition); } }
    public bool hasEndPosition { get { return HasComponent(GameComponentsLookup.EndPosition); } }

    public void AddEndPosition(UnityEngine.Vector3 newValue) {
        var index = GameComponentsLookup.EndPosition;
        var component = (EndPositionComponent)CreateComponent(index, typeof(EndPositionComponent));
        component.value = newValue;
        AddComponent(index, component);
    }

    public void ReplaceEndPosition(UnityEngine.Vector3 newValue) {
        var index = GameComponentsLookup.EndPosition;
        var component = (EndPositionComponent)CreateComponent(index, typeof(EndPositionComponent));
        component.value = newValue;
        ReplaceComponent(index, component);
    }

    public void RemoveEndPosition() {
        RemoveComponent(GameComponentsLookup.EndPosition);
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

    static Entitas.IMatcher<GameEntity> _matcherEndPosition;

    public static Entitas.IMatcher<GameEntity> EndPosition {
        get {
            if (_matcherEndPosition == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.EndPosition);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherEndPosition = matcher;
            }

            return _matcherEndPosition;
        }
    }
}
