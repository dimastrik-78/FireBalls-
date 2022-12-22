using System;
using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using Interface;
using Service;

namespace GunSystem
{
    public class ListenerInput : MonoBehaviour
    {
        public static Action<int> CountBullet;

        [SerializeField] private GameObject prefabBullet;
        [SerializeField] private Transform spawnPoint;
        [SerializeField] private int countBullets;
        [SerializeField] private float recharge;

        private Action _action;
        private float _variableRecharge;
        private int _remainingBullets;

        void Start()
        {
            _action = new Action();

            _variableRecharge = recharge;
            _remainingBullets = countBullets;
            
            CountBullet?.Invoke(_remainingBullets);
        }

        void Update()
        {
            if (Input.GetKeyDown(KeyCode.Mouse0))
            {
                Shooting();
            }

            if (_remainingBullets <= 0)
            {
                if (Check.Timer(ref _variableRecharge))
                {
                    _variableRecharge = recharge;
                    _remainingBullets = countBullets;
                    CountBullet?.Invoke(_remainingBullets);
                }
            }
        }

        private void Shooting()
        {
            if (_remainingBullets > 0)
            {
                _action.Shoot(prefabBullet, spawnPoint);
                _remainingBullets--;
                CountBullet?.Invoke(_remainingBullets);
            }
        }
    }
}
