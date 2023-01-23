using Core.Configs;
using Core.Extension;
using Entitas;
using UnityEngine;

public class PlayerView : MonoBehAdvGame, ISetDefaultStateListener
{
    [SerializeField] private Transform AmmoTransform;

    private GameConfig _gameCpnfig;

    public override void Init(IEntity iEntity)
    {
        _gameCpnfig = ConfigsCatalogsManager.GetConfig<GameConfig>();

        base.Init(iEntity);
        GameEntity.isPlayer = true;
        GameEntity.AddSpeed(_gameCpnfig.PlayerSpeed);
        GameEntity.AddAmmoTransform(AmmoTransform);
        GameEntity.AddHealth(_gameCpnfig.PlayerHealth);
        GameEntity.AddDefeance(_gameCpnfig.PlayerDefeance);

        GameEntity.AddSetDefaultStateListener(this);

        var uIPlayerHealth = Object.FindObjectOfType<UIPlayerHealth>(includeInactive: true);
        GameEntity.AddHealthListener(uIPlayerHealth);
    }

    public void OnSetDefaultState(GameEntity entity)
    {
        GameEntity.ReplaceHealth(_gameCpnfig.PlayerHealth);
    }
}