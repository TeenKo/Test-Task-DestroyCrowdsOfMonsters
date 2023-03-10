//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public EnemyDeathCountComponent enemyDeathCount { get { return (EnemyDeathCountComponent)GetComponent(GameComponentsLookup.EnemyDeathCount); } }
    public bool hasEnemyDeathCount { get { return HasComponent(GameComponentsLookup.EnemyDeathCount); } }

    public void AddEnemyDeathCount(int newValue) {
        var index = GameComponentsLookup.EnemyDeathCount;
        var component = (EnemyDeathCountComponent)CreateComponent(index, typeof(EnemyDeathCountComponent));
        component.value = newValue;
        AddComponent(index, component);
    }

    public void ReplaceEnemyDeathCount(int newValue) {
        var index = GameComponentsLookup.EnemyDeathCount;
        var component = (EnemyDeathCountComponent)CreateComponent(index, typeof(EnemyDeathCountComponent));
        component.value = newValue;
        ReplaceComponent(index, component);
    }

    public void RemoveEnemyDeathCount() {
        RemoveComponent(GameComponentsLookup.EnemyDeathCount);
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

    static Entitas.IMatcher<GameEntity> _matcherEnemyDeathCount;

    public static Entitas.IMatcher<GameEntity> EnemyDeathCount {
        get {
            if (_matcherEnemyDeathCount == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.EnemyDeathCount);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherEnemyDeathCount = matcher;
            }

            return _matcherEnemyDeathCount;
        }
    }
}
