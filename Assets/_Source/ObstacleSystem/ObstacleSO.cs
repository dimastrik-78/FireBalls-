using UnityEngine;

namespace ObstacleSystem
{
    [CreateAssetMenu(fileName = "Obstacle", menuName = "Obstacle")]
    public class ObstacleSO : ScriptableObject
    {
        [SerializeField] private GameObject prefabPancake;
        [SerializeField] private int decreasePoints;
        
        public GameObject PrefabPancake => prefabPancake;
        public int DecreasePoints => decreasePoints;
    }
}
