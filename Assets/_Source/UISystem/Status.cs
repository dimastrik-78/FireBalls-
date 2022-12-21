using System;
using Interface;
using UnityEngine;
using UnityEngine.UI;

namespace UISystem
{
    public class Status : MonoBehaviour, IObserver
    {
        [SerializeField] private Image image;

        private int _maxCountBullet;
        private float _share;

        public void OnNotify(int countBullet)
        {
            if (_maxCountBullet == 0)
            {
                _maxCountBullet = countBullet;
            }
            else
            {
                image.fillAmount = (float)countBullet / _maxCountBullet;
            }
        }
    }
}
