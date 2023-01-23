//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class InputEntity {

    public CameraRayComponent cameraRay { get { return (CameraRayComponent)GetComponent(InputComponentsLookup.CameraRay); } }
    public bool hasCameraRay { get { return HasComponent(InputComponentsLookup.CameraRay); } }

    public void AddCameraRay(UnityEngine.Ray newValue) {
        var index = InputComponentsLookup.CameraRay;
        var component = (CameraRayComponent)CreateComponent(index, typeof(CameraRayComponent));
        component.value = newValue;
        AddComponent(index, component);
    }

    public void ReplaceCameraRay(UnityEngine.Ray newValue) {
        var index = InputComponentsLookup.CameraRay;
        var component = (CameraRayComponent)CreateComponent(index, typeof(CameraRayComponent));
        component.value = newValue;
        ReplaceComponent(index, component);
    }

    public void RemoveCameraRay() {
        RemoveComponent(InputComponentsLookup.CameraRay);
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

    static Entitas.IMatcher<InputEntity> _matcherCameraRay;

    public static Entitas.IMatcher<InputEntity> CameraRay {
        get {
            if (_matcherCameraRay == null) {
                var matcher = (Entitas.Matcher<InputEntity>)Entitas.Matcher<InputEntity>.AllOf(InputComponentsLookup.CameraRay);
                matcher.componentNames = InputComponentsLookup.componentNames;
                _matcherCameraRay = matcher;
            }

            return _matcherCameraRay;
        }
    }
}
