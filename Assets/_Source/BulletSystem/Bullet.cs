using System;
using Service;
using UnityEngine;

namespace BulletSystem
{
    public class Bullet : MonoBehaviour
    {
        [SerializeField] private float timeLive;
        [SerializeField] private int speedMove;

        private Rigidbody _rigidbody;
        
        void Start()
        {
            _rigidbody = GetComponent<Rigidbody>();
            _rigidbody.AddForce(transform.forward * speedMove, ForceMode.Impulse);
        }

        private void Update()
        {
            if (Check.Timer(ref timeLive))
                Destroy(gameObject);
        }

        private void OnCollisionEnter(Collision collision)
        {
            if (collision.gameObject.layer == 7
                || collision.gameObject.layer == 8)
            {
                Destroy(gameObject);
            }
        }
    }
}
