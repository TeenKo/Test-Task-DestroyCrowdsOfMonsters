using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class TargetImageView : MonoBehaviour, ICameraRayListener
{
    private Transform _transform;

    private void Start()
    {
        _transform = transform;
        Contexts.sharedInstance.input.mouseContolEntity.AddCameraRayListener(this);
    }

    public void OnCameraRay(InputEntity entity, Ray value)
    {
        _transform.position = value.GetPoint(entity.cameraRayDistance.value - 0.5f);
    }
}
