//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public DefeanceComponent defeance { get { return (DefeanceComponent)GetComponent(GameComponentsLookup.Defeance); } }
    public bool hasDefeance { get { return HasComponent(GameComponentsLookup.Defeance); } }

    public void AddDefeance(float newValue) {
        var index = GameComponentsLookup.Defeance;
        var component = (DefeanceComponent)CreateComponent(index, typeof(DefeanceComponent));
        component.value = newValue;
        AddComponent(index, component);
    }

    public void ReplaceDefeance(float newValue) {
        var index = GameComponentsLookup.Defeance;
        var component = (DefeanceComponent)CreateComponent(index, typeof(DefeanceComponent));
        component.value = newValue;
        ReplaceComponent(index, component);
    }

    public void RemoveDefeance() {
        RemoveComponent(GameComponentsLookup.Defeance);
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

    static Entitas.IMatcher<GameEntity> _matcherDefeance;

    public static Entitas.IMatcher<GameEntity> Defeance {
        get {
            if (_matcherDefeance == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.Defeance);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherDefeance = matcher;
            }

            return _matcherDefeance;
        }
    }
}
