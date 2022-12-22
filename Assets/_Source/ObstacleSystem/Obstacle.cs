using System.Collections.Generic;
using Interface;
using UnityEngine;

namespace ObstacleSystem
{
    public class Obstacle : MonoBehaviour, IObservable
    {
        [SerializeField] private ObstacleSO obstacleInfo;
        [SerializeField] private Transform centralPointPancakes;
        [SerializeField] private float speedRotate;
        
        private List<IObserver> _observers;

        private void Start()
        {
            _observers = new List<IObserver>();
        }
        
        void Update()
        {
            transform.RotateAround(centralPointPancakes.position, Vector3.up, speedRotate * Time.deltaTime);
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
                _observers[i].OnNotify(-obstacleInfo.DecreasePoints);
            }
        }
    }
}
