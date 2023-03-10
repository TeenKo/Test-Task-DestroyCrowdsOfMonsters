//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    static readonly AttackPlayerComponent attackPlayerComponent = new AttackPlayerComponent();

    public bool isAttackPlayer {
        get { return HasComponent(GameComponentsLookup.AttackPlayer); }
        set {
            if (value != isAttackPlayer) {
                var index = GameComponentsLookup.AttackPlayer;
                if (value) {
                    var componentPool = GetComponentPool(index);
                    var component = componentPool.Count > 0
                            ? componentPool.Pop()
                            : attackPlayerComponent;

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

    static Entitas.IMatcher<GameEntity> _matcherAttackPlayer;

    public static Entitas.IMatcher<GameEntity> AttackPlayer {
        get {
            if (_matcherAttackPlayer == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.AttackPlayer);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherAttackPlayer = matcher;
            }

            return _matcherAttackPlayer;
        }
    }
}
