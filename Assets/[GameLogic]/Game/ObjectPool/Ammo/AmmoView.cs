using Core.Extension;
using DG.Tweening;
using Entitas;
using UnityEngine;

public class AmmoView : MonoBehAdvGame, IAmmoStateListener
{
    [SerializeField] private ParticleSystem ExplosionParticle;
    private Tween _ammoFlyTween;
    public override void Init(IEntity iEntity)
    {
        base.Init(iEntity);
        GameEntity.isAmmo = true;
        GameEntity.AddAmmoState(AmmoPoolState.Idle);
        GameEntity.AddEndPosition(Vector3.zero);
        GameEntity.AddAmmoStateListener(this);
    }

    public void OnAmmoState(GameEntity entity, AmmoPoolState value)
    {
        switch (value)
        {
            case AmmoPoolState.Idle:
                transform.position = Vector3.zero;
                break;
            case AmmoPoolState.Busy:
                AmmoTweenAnimation(entity.endPosition.value);
                break;
        }
    }

    private void AmmoTweenAnimation(Vector3 endValue)
    {
        _ammoFlyTween.Rewind();
        _ammoFlyTween.Kill();
        _ammoFlyTween = transform.DOJump(endValue, 2f, 1, 1).SetEase(Ease.Linear)
            .OnComplete(() =>
            {
                GameEntity.isExplosion = true;
                ExplosionParticle.Play();
            });
    }
}