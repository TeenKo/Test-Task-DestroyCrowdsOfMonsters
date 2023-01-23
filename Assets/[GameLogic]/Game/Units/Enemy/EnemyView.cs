using Core.Configs;
using Core.Extension;
using DG.Tweening;
using Entitas;
using System;
using System.Collections.Generic;
using UnityEngine;
using static PoolConfig;

public class EnemyView : MonoBehAdvGame, IDeathListener, ITakeDamageListener, ISetDefaultStateListener
{
    [SerializeField] private Material TakeDamageMaterial;

    private MeshRenderer[] _meshRenderers;
    private List<Material> materials = new List<Material>();
    private PoolConfig _poolConfig;
    private Tween _deathTween;

    public override void Init(IEntity iEntity)
    {
        _poolConfig = ConfigsCatalogsManager.GetConfig<PoolConfig>();

        _meshRenderers = GetComponentsInChildren<MeshRenderer>();

        foreach (var meshRenderer in _meshRenderers)
        {
            materials.Add(meshRenderer.material);
        }

        base.Init(iEntity);

        foreach (var enemy in _poolConfig.Enemies)
        {
            if (GameEntity.enemyType.value == enemy.EnemyType)
            {
                GameEntity.isEnemy = true;
                GameEntity.AddDamage(enemy.Damage);
                GameEntity.AddHealth(enemy.Health);
                GameEntity.AddDefeance(enemy.Defence);
                GameEntity.AddAttackSpeed(enemy.AttackSpeed);
                GameEntity.AddAttackDistance(enemy.AttackDistancce);
                GameEntity.AddSpeed(enemy.Speed);
                GameEntity.AddEnemyPoolState(EnemyPoolState.Idle);
                break;
            }
        }

        GameEntity.AddSetDefaultStateListener(this);
        GameEntity.AddDeathListener(this);
        GameEntity.AddTakeDamageListener(this);
    }

    public void OnSetDefaultState(GameEntity entity)
    {
        foreach (var enemy in _poolConfig.Enemies)
        {
            if (GameEntity.enemyType.value == enemy.EnemyType)
            {
                GameEntity.isEnemyAttack = false;
                GameEntity.isAttackPlayer = false;
                GameEntity.ReplaceHealth(enemy.Health);
                GameEntity.ReplaceEnemyPoolState(EnemyPoolState.Idle);
            }
        }
    }

    public void OnDeath(GameEntity entity)
    {
        if (_deathTween == null)
        {
            _deathTween = transform.DOScale(Vector3.zero, 0.3f).SetAutoKill(false).SetEase(Ease.Linear).Pause()
                .OnComplete(() => GameEntity.ReplaceEnemyPoolState(EnemyPoolState.Idle));
        }

        _deathTween.Restart();
    }

    public void OnTakeDamage(GameEntity entity)
    {
        float value = 0f;
        //DoTween Timer
        DOTween.To(() => value, x => value = x, 1f, 0.3f) 
            .OnStart(() =>
            {
                foreach (var meshRenderer in _meshRenderers)
                {
                    meshRenderer.material = TakeDamageMaterial;
                }
            })
            .OnComplete(() =>
            {
                foreach (var meshRenderer in _meshRenderers)
                {
                    meshRenderer.material = materials[Array.IndexOf(_meshRenderers, meshRenderer)];
                }
            });

    }
}