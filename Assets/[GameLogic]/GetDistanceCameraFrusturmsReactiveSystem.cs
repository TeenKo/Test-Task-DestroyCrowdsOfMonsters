using Entitas;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class GetDistanceCameraFrusturmsReactiveSystem : ReactiveSystem<GameEntity>
{
    private Contexts _contexts;

    public GetDistanceCameraFrusturmsReactiveSystem(Contexts contexts) : base(contexts.game)
    {
        _contexts = contexts;
    }

    protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context)
    {
        return context.CreateCollector(GameMatcher.Player);
    }

    protected override bool Filter(GameEntity entity)
    {
        return true;
    }

    protected override void Execute(List<GameEntity> entities)
    {
        var playerEntity = entities.FirstOrDefault();
        var playerTransform = playerEntity.transform.value;

        Ray rightRay = new Ray(playerTransform.position, Vector3.right * 10000);
        Ray forwardRay = new Ray(playerTransform.position, Vector3.forward * 10000);
        Ray backRay = new Ray(playerTransform.position, Vector3.back * 10000);

        Plane[] planes = GeometryUtility.CalculateFrustumPlanes(Camera.main);

        var minDistanceRight = Mathf.Infinity;
        var minDistanceForward = Mathf.Infinity;
        var minDistanceback = Mathf.Infinity;

        //[0] = Left, [1] = Right, [2] = Back, [3] = Forward
        for (int i = 0; i < 4; i++)
        {
            if (planes[i].Raycast(rightRay, out float distanceR))
            {
                if (distanceR < minDistanceRight) { minDistanceRight = distanceR; }
            }

            if (planes[i].Raycast(forwardRay, out float distanceF))
            {
                if (distanceF < minDistanceForward) { minDistanceForward = distanceF; }
            }

            if (planes[i].Raycast(backRay, out float distanceB))
            {
                if (distanceB < minDistanceback) { minDistanceback = distanceB; }
            }
        }

        float[] distance = { -minDistanceRight, minDistanceRight, -minDistanceback, minDistanceForward };

        playerEntity.AddDistanceCameraFrusturms(distance);

    }
}