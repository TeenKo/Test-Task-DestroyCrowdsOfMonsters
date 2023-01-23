using Core.Configs;
using Entitas;
using System.Linq;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UIPlayerHealth : MonoBehaviour, IHealthListener
{
    [SerializeField] private TextMeshProUGUI TextHP;
    [SerializeField] private Image FillImageHP;
    private GameConfig _gameConfig;

    private void Start()
    {
        _gameConfig = ConfigsCatalogsManager.GetConfig<GameConfig>();
    }
    public void OnHealth(GameEntity entity, float value)
    {
        TextHP.text = value.ToString();
        FillImageHP.fillAmount = value / _gameConfig.PlayerHealth;
    }
}
