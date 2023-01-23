//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    static readonly StartAttackComponent startAttackComponent = new StartAttackComponent();

    public bool isStartAttack {
        get { return HasComponent(GameComponentsLookup.StartAttack); }
        set {
            if (value != isStartAttack) {
                var index = GameComponentsLookup.StartAttack;
                if (value) {
                    var componentPool = GetComponentPool(index);
                    var component = componentPool.Count > 0
                            ? componentPool.Pop()
                            : startAttackComponent;

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

    static Entitas.IMatcher<GameEntity> _matcherStartAttack;

    public static Entitas.IMatcher<GameEntity> StartAttack {
        get {
            if (_matcherStartAttack == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.StartAttack);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherStartAttack = matcher;
            }

            return _matcherStartAttack;
        }
    }
}
