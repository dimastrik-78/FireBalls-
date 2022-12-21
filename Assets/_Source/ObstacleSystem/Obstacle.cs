using UnityEngine;

namespace ObstacleSystem
{
    public class Obstacle : MonoBehaviour
    {
        [SerializeField] private Transform centralPointPancakes;
        [SerializeField] private float speedRotate;

        void Update()
        {
            transform.RotateAround(centralPointPancakes.position, Vector3.up, speedRotate * Time.deltaTime);
        }

        private void OnCollisionEnter(Collision collision)
        {
            if (collision.gameObject.layer == 6)
                Destroy(gameObject);
        }
    }
}
