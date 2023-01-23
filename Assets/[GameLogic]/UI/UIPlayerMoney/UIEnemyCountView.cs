using Core.UI;
using Entitas;
using TMPro;
using UnityEngine;

namespace UI
{
    public sealed class UIEnemyCountView : UIElement, IUIPlayerMoneyShowListener, IUIPlayerMoneyHideListener,
        IEnemyDeathCountListener
    {
        [SerializeField] private TextMeshProUGUI moneyTextField;

        public override void Init(IEntity iEntity)
        {
            base.Init(iEntity);
            UIEntity.isUIPlayerMoney = true;
            UIEntity.AddUIPlayerMoneyShowListener(this);
            UIEntity.AddUIPlayerMoneyHideListener(this);
            Contexts.sharedInstance.game.userDataEntity.AddEnemyDeathCountListener(this);
        }

        public void OnUIPlayerMoneyShow(UiEntity entity)
        {
            gameObject.SetActive(true);
        }

        public void OnUIPlayerMoneyHide(UiEntity entity)
        {
            gameObject.SetActive(false);
        }

        public void OnEnemyDeathCount(GameEntity entity, int value)
        {
            moneyTextField.text = value.ToString();
        }
    }
}