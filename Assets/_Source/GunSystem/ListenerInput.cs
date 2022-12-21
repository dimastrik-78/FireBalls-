using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using Interface;
using Service;

namespace GunSystem
{
    public class ListenerInput : MonoBehaviour, IObservable
    {
        [SerializeField] private GameObject prefabBullet;
        [SerializeField] private Transform spawnPoint;
        [SerializeField] private int countBullets;
        [SerializeField] private float recharge;

        private Action _action;
        private List<IObserver> _observers;
        private float _variableRecharge;
        private int _remainingBullets;

        void Awake()
        {
            _action = new Action();
            _observers = new List<IObserver>();

            _variableRecharge = recharge;
            _remainingBullets = countBullets;
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
                    Notify();
                }
            }
        }

        private void Shooting()
        {
            if (_remainingBullets > 0)
            {
                _action.Shoot(prefabBullet, spawnPoint);
                _remainingBullets--;
                Notify();
            }
        }
        
        public void Register(IObserver observer)
        {
            _observers.Add(observer);
        }

        public void Remove(IObserver observer)
        {
            _observers.Remove(observer);
        }

        public void Notify()
        {
            for (int i = 0; i < _observers.Count; i++)
            {
                _observers[i].OnNotify(_remainingBullets);
            }
        }
    }
}
