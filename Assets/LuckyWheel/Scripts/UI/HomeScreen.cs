using System;
using DG.Tweening;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

namespace BabySound
{
    public class HomeScreen : AppScreen
    {
        [SerializeField] private TextMeshProUGUI _coinTMP;
        [SerializeField] private GameObject _hide;

        public override ScreenType GetID()
        {
            return ScreenType.HomeScreen;
        }

        protected override void Start()
        {
            base.Start();
            //SetCoinText();
            GameManager.CloseHome += CloseHome;
        }

        private void CloseHome(bool obj)
        {
            _hide.SetActive(obj);
        }

        public override void OnOpen()
        {
            base.OnOpen();
            _hide.SetActive(true);
        }

        private void OnChangeCoin(int i)
        {
            SetCoinText();
        }

        private void SetCoinText()
        {
            _coinTMP.SetText(GameDataManager.Instance.playerData.coin.ToString() + "<sprite=0>");
        }

        private void OnDestroy()
        {
            GameManager.OnChangeBullet -= OnChangeCoin;
        }

        public override void Remove()
        {
            base.Remove();
            _hide.SetActive(false);
        }
    }
}