//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class StateEntity {

    public AnyCompleteLevelListenerComponent anyCompleteLevelListener { get { return (AnyCompleteLevelListenerComponent)GetComponent(StateComponentsLookup.AnyCompleteLevelListener); } }
    public bool hasAnyCompleteLevelListener { get { return HasComponent(StateComponentsLookup.AnyCompleteLevelListener); } }

    public void AddAnyCompleteLevelListener(System.Collections.Generic.List<IAnyCompleteLevelListener> newValue) {
        var index = StateComponentsLookup.AnyCompleteLevelListener;
        var component = (AnyCompleteLevelListenerComponent)CreateComponent(index, typeof(AnyCompleteLevelListenerComponent));
        component.value = newValue;
        AddComponent(index, component);
    }

    public void ReplaceAnyCompleteLevelListener(System.Collections.Generic.List<IAnyCompleteLevelListener> newValue) {
        var index = StateComponentsLookup.AnyCompleteLevelListener;
        var component = (AnyCompleteLevelListenerComponent)CreateComponent(index, typeof(AnyCompleteLevelListenerComponent));
        component.value = newValue;
        ReplaceComponent(index, component);
    }

    public void RemoveAnyCompleteLevelListener() {
        RemoveComponent(StateComponentsLookup.AnyCompleteLevelListener);
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
public sealed partial class StateMatcher {

    static Entitas.IMatcher<StateEntity> _matcherAnyCompleteLevelListener;

    public static Entitas.IMatcher<StateEntity> AnyCompleteLevelListener {
        get {
            if (_matcherAnyCompleteLevelListener == null) {
                var matcher = (Entitas.Matcher<StateEntity>)Entitas.Matcher<StateEntity>.AllOf(StateComponentsLookup.AnyCompleteLevelListener);
                matcher.componentNames = StateComponentsLookup.componentNames;
                _matcherAnyCompleteLevelListener = matcher;
            }

            return _matcherAnyCompleteLevelListener;
        }
    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.EventEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class StateEntity {

    public void AddAnyCompleteLevelListener(IAnyCompleteLevelListener value) {
        var listeners = hasAnyCompleteLevelListener
            ? anyCompleteLevelListener.value
            : new System.Collections.Generic.List<IAnyCompleteLevelListener>();
        listeners.Add(value);
        ReplaceAnyCompleteLevelListener(listeners);
    }

    public void RemoveAnyCompleteLevelListener(IAnyCompleteLevelListener value, bool removeComponentWhenEmpty = true) {
        var listeners = anyCompleteLevelListener.value;
        listeners.Remove(value);
        if (removeComponentWhenEmpty && listeners.Count == 0) {
            RemoveAnyCompleteLevelListener();
        } else {
            ReplaceAnyCompleteLevelListener(listeners);
        }
    }
}