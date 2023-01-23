//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class UiEntity {

    public Core.Common.GameObjectEnabledComponent gameObjectEnabled { get { return (Core.Common.GameObjectEnabledComponent)GetComponent(UiComponentsLookup.GameObjectEnabled); } }
    public bool hasGameObjectEnabled { get { return HasComponent(UiComponentsLookup.GameObjectEnabled); } }

    public void AddGameObjectEnabled(bool newValue) {
        var index = UiComponentsLookup.GameObjectEnabled;
        var component = (Core.Common.GameObjectEnabledComponent)CreateComponent(index, typeof(Core.Common.GameObjectEnabledComponent));
        component.value = newValue;
        AddComponent(index, component);
    }

    public void ReplaceGameObjectEnabled(bool newValue) {
        var index = UiComponentsLookup.GameObjectEnabled;
        var component = (Core.Common.GameObjectEnabledComponent)CreateComponent(index, typeof(Core.Common.GameObjectEnabledComponent));
        component.value = newValue;
        ReplaceComponent(index, component);
    }

    public void RemoveGameObjectEnabled() {
        RemoveComponent(UiComponentsLookup.GameObjectEnabled);
    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiInterfaceGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class UiEntity : IGameObjectEnabledEntity { }

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentMatcherApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public sealed partial class UiMatcher {

    static Entitas.IMatcher<UiEntity> _matcherGameObjectEnabled;

    public static Entitas.IMatcher<UiEntity> GameObjectEnabled {
        get {
            if (_matcherGameObjectEnabled == null) {
                var matcher = (Entitas.Matcher<UiEntity>)Entitas.Matcher<UiEntity>.AllOf(UiComponentsLookup.GameObjectEnabled);
                matcher.componentNames = UiComponentsLookup.componentNames;
                _matcherGameObjectEnabled = matcher;
            }

            return _matcherGameObjectEnabled;
        }
    }
}