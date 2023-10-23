using System;
using DG.Tweening;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

namespace BabySound
{
    public class GameScreen : AppScreen
    {
        [SerializeField] private TextMeshProUGUI _coinTMP;

        public override ScreenType GetID()
        {
            return ScreenType.Game;
        }

        protected override void Start()
        {
            base.Start();
            //SetCoinText();
            //GameManager.OnChangeCoin += OnChangeCoin;
        }
        
    }
}