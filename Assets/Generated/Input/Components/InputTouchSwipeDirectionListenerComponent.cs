//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class InputEntity {

    public TouchSwipeDirectionListenerComponent touchSwipeDirectionListener { get { return (TouchSwipeDirectionListenerComponent)GetComponent(InputComponentsLookup.TouchSwipeDirectionListener); } }
    public bool hasTouchSwipeDirectionListener { get { return HasComponent(InputComponentsLookup.TouchSwipeDirectionListener); } }

    public void AddTouchSwipeDirectionListener(System.Collections.Generic.List<ITouchSwipeDirectionListener> newValue) {
        var index = InputComponentsLookup.TouchSwipeDirectionListener;
        var component = (TouchSwipeDirectionListenerComponent)CreateComponent(index, typeof(TouchSwipeDirectionListenerComponent));
        component.value = newValue;
        AddComponent(index, component);
    }

    public void ReplaceTouchSwipeDirectionListener(System.Collections.Generic.List<ITouchSwipeDirectionListener> newValue) {
        var index = InputComponentsLookup.TouchSwipeDirectionListener;
        var component = (TouchSwipeDirectionListenerComponent)CreateComponent(index, typeof(TouchSwipeDirectionListenerComponent));
        component.value = newValue;
        ReplaceComponent(index, component);
    }

    public void RemoveTouchSwipeDirectionListener() {
        RemoveComponent(InputComponentsLookup.TouchSwipeDirectionListener);
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
public sealed partial class InputMatcher {

    static Entitas.IMatcher<InputEntity> _matcherTouchSwipeDirectionListener;

    public static Entitas.IMatcher<InputEntity> TouchSwipeDirectionListener {
        get {
            if (_matcherTouchSwipeDirectionListener == null) {
                var matcher = (Entitas.Matcher<InputEntity>)Entitas.Matcher<InputEntity>.AllOf(InputComponentsLookup.TouchSwipeDirectionListener);
                matcher.componentNames = InputComponentsLookup.componentNames;
                _matcherTouchSwipeDirectionListener = matcher;
            }

            return _matcherTouchSwipeDirectionListener;
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
public partial class InputEntity {

    public void AddTouchSwipeDirectionListener(ITouchSwipeDirectionListener value) {
        var listeners = hasTouchSwipeDirectionListener
            ? touchSwipeDirectionListener.value
            : new System.Collections.Generic.List<ITouchSwipeDirectionListener>();
        listeners.Add(value);
        ReplaceTouchSwipeDirectionListener(listeners);
    }

    public void RemoveTouchSwipeDirectionListener(ITouchSwipeDirectionListener value, bool removeComponentWhenEmpty = true) {
        var listeners = touchSwipeDirectionListener.value;
        listeners.Remove(value);
        if (removeComponentWhenEmpty && listeners.Count == 0) {
            RemoveTouchSwipeDirectionListener();
        } else {
            ReplaceTouchSwipeDirectionListener(listeners);
        }
    }
}
