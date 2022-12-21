using System;
using System.Collections.Generic;
using Interface;
using UnityEngine;

namespace TargetSystem
{
    public class Pancake : MonoBehaviour, IObservable
    {
        [SerializeField] private PancakeSO pancakeInfo;

        private List<IObserver> _observers;

        private void Start()
        {
            _observers = new List<IObserver>();
        }

        private void OnCollisionEnter(Collision collision)
        {
            if (collision.gameObject.layer == 6)
            {
                Notify();
                Destroy(gameObject);
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
                _observers[i].OnNotify(pancakeInfo.GivesPoints);
            }
        }
    }
}
